using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Antares.Essentials.Configuration;
using FantasyEPL.Sync.Configurations;
using FantasyEPL.Sync.Services;
using FantasyEPL.Sync.Mappers;
using FantasyEPL.Data;
using Antares.Essentials.Data.Repositories;
using Antares.Essentials.Data.UoW;

namespace FantasyEPL.Sync
{
    class Program
    {
        static IServiceProvider Provider;

        static void Main(string[] args)
        {
            Console.WriteLine("Bootstraping...");
            Bootstrap(args);

            Task.Run(async () =>
            {
                Console.WriteLine("Start retrieving data process...");
                Console.WriteLine("Fetching data...");

                var dataService = Provider.GetService<IFPLDataProviderService>();
                var data = await dataService.GetStaticDataAsync();

                if (data != null)
                {
                    Console.WriteLine("Analyzing data...");
                    var fixture = data.Events.SingleOrDefault(e => e.IsCurrent);
                    if(fixture == null)
                    {
                        fixture = new Models.Event
                        {
                            Id = 0,
                            Name = "Trial",
                            IsCurrent = true
                        };

                        data.Events.Add(fixture);
                    }

                    var syncService = Provider.GetService<IFPLSyncService>();
                    var uow = Provider.GetService<IUnitOfWork>();

                    uow.BeginTransaction();
                    Console.WriteLine("Start synchronizing process...");

                    Console.WriteLine("Synchronizing Events...");
                    syncService.SyncEvents(data.Events);

                    Console.WriteLine("Synchronizing Player positions...");
                    syncService.SyncPlayerPositions(data.ElementTypes);

                    Console.WriteLine("Synchronizing Teams...");
                    syncService.SyncTeams(data.Teams);
                    syncService.SyncTeamsByEvent(fixture, data.Teams);

                    Console.WriteLine("Synchronizing Players...");
                    syncService.SyncPlayers(data.Elements);
                    syncService.SyncPlayersByEvent(fixture, data.Elements);
                    uow.EndTransaction();
                    Console.WriteLine("Finished successfully.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Empty... Stop for now.");
                }

            }).GetAwaiter().GetResult();
        }

        static void Bootstrap(string[] args)
        {
            var services = new ServiceCollection()
                                .AddSingleton<IAppSettings, AppSettings>()
                                .AddSingleton<SyncOptions>();

            var fileCommand = Array.IndexOf(args, "-f");
            if (args != null && fileCommand > -1)
            {
                if (args.Length - 1 > fileCommand && !args[fileCommand + 1].StartsWith("-")) // if next arg is value
                {
                    services.AddSingleton<IFileLocator>(p => new FileLocator { DefaultFile = args[fileCommand + 1] });
                }
                else
                {
                    services.AddSingleton<IFileLocator>(p => p.GetService<SyncOptions>().Local);
                }

                services.AddTransient<IFPLDataProviderService, FileFPLDataProviderService>();
            }
            else
            {
                services
                    .AddSingleton(p => p.GetService<SyncOptions>().OverTheWire)
                    .AddSingleton<FPLHttpClient>()
                    .AddTransient<IFPLDataProviderService, LiveFPLDataProviderService>();
            }

            services.AddDbContext<FPLContext>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(FPLGenericRepository<>));
            services.AddTransient<IUnitOfWork, FPLUnitOfWork>();
            services.AddTransient<IFPLSyncService, FPLSyncService>();

            services.AddSingleton(AutoMapperConfig.RegisterMappings().CreateMapper());

            Provider = services.BuildServiceProvider();
        }

        class FileLocator : IFileLocator
        {
            public string DefaultFile { get; set; }
        }
    }
}
