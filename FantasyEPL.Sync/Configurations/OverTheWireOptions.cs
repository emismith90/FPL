using Microsoft.Extensions.Configuration;
using Antares.Essentials.Configuration;

namespace FantasyEPL.Sync.Configurations
{
    public class OverTheWireOptions : OptionsBase
    {
        public OverTheWireOptions(IConfiguration scope) : base(scope)
        {
        }

        public string BaseUri => GetString();

        private EndpointOptions _endpoint;
        public EndpointOptions Endpoint
        {
            get
            {
                return _endpoint ?? (_endpoint = new EndpointOptions(CurrentSection));
            }
        }
    }
}
