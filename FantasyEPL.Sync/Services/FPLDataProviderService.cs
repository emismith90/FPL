using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Services
{
    public abstract class FPLDataProviderService : IFPLDataProviderService
    {
        private readonly JsonSerializerSettings Settings;
        public FPLDataProviderService()
        {
            Settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };
        }
        public async Task<Static> GetStaticDataAsync()
        {
            try
            {
                var raw = await this.GetRawDataAsync();

                return JsonConvert.DeserializeObject<Static>(raw, Settings);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected abstract Task<string> GetRawDataAsync();
    }
}
