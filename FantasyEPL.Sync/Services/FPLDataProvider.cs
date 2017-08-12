using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Services
{
    public abstract class FPLDataProvider : IFPLDataProvider
    {
        private readonly JsonSerializerSettings Settings;
        public FPLDataProvider()
        {
            Settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };
        }
        public async Task<Static> GetStaticData()
        {
            try
            {
                var raw = await this.GetRawData();

                return JsonConvert.DeserializeObject<Static>(raw, Settings);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected abstract Task<string> GetRawData();
    }
}
