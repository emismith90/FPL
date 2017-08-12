using System.Threading.Tasks;
using FantasyEPL.Sync.Configurations;

namespace FantasyEPL.Sync.Services
{
    public class LiveFPLDataProvider : FPLDataProvider, IFPLDataProvider
    {
        public readonly FPLHttpClient HttpClient;
        public readonly OverTheWireOptions Options;

        public LiveFPLDataProvider(FPLHttpClient httpClient, OverTheWireOptions options)
        {
            HttpClient = httpClient;
            Options = options;
        }

        protected override async Task<string> GetRawData()
        {
            try
            { 
                var response = await HttpClient.GetAsync(Options.Endpoint.BootstrapStatic);
                response.EnsureSuccessStatusCode();
                var content = response.Content;

                return await content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
