using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Antares.Essentials.Configuration;
using FantasyEPL.Sync.Configurations;
using FantasyEPL.Sync.Services;

namespace FantasyEPL.Sync
{
    class Program
    {
        static IServiceProvider Provider;

        static void Main(string[] args)
        {
            Bootstrap(args);

            Task.Run(async () =>
            {
                var fplDataProvider = Provider.GetService<IFPLDataProvider>();
                var data = await fplDataProvider.GetStaticData();

                if (data != null)
                {
                    Console.WriteLine("Success!");
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
                Console.WriteLine("Reading from file...");
                if (args.Length - 1 > fileCommand && !args[fileCommand + 1].StartsWith("-")) // if next arg is value
                {
                    services.AddSingleton<IFileLocator>(p => new FileLocator { DefaultFile = args[fileCommand + 1]});
                }
                else
                {
                    services.AddSingleton<IFileLocator>(p => p.GetService<SyncOptions>().Local);
                }

                services.AddSingleton<IFPLDataProvider, FileFPLDataProvider>();
            }
            else
            {
                Console.WriteLine("Reading from live...");
                services
                    .AddSingleton(p => p.GetService<SyncOptions>().OverTheWire)
                    .AddSingleton<FPLHttpClient>()
                    .AddSingleton<IFPLDataProvider, LiveFPLDataProvider>();
            }

            Provider = services.BuildServiceProvider();
        }

        class FileLocator : IFileLocator
        {
            public string DefaultFile { get; set; }
        }
    }
}