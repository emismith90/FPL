using Microsoft.Extensions.Configuration;
using Antares.Essentials.Configuration;

namespace FantasyEPL.Sync.Configurations
{
    public class EndpointOptions : OptionsBase
    {
        public EndpointOptions(IConfiguration scope) : base(scope)
        {
        }

        public string ElementSummary => GetString();
        public string BootstrapStatic => GetString();
        public string BootstrapDynamic => GetString();
    }
}
