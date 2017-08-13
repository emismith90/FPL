using System.IO;
using System.Threading.Tasks;
using FantasyEPL.Sync.Configurations;

namespace FantasyEPL.Sync.Services
{
    public class FileFPLDataProviderService : FPLDataProviderService, IFPLDataProviderService
    {
        public readonly IFileLocator Options;

        public FileFPLDataProviderService(IFileLocator options)
        {
            Options = options;
        }

        protected override async Task<string> GetRawDataAsync()
        {
            try
            {
                using (var reader = File.OpenText(Options.DefaultFile))
                {
                    return await reader.ReadToEndAsync();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
