using System.IO;
using System.Threading.Tasks;
using FantasyEPL.Sync.Configurations;

namespace FantasyEPL.Sync.Services
{
    public class FileFPLDataProvider : FPLDataProvider, IFPLDataProvider
    {
        public readonly IFileLocator Options;

        public FileFPLDataProvider(IFileLocator options)
        {
            Options = options;
        }

        protected override async Task<string> GetRawData()
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
