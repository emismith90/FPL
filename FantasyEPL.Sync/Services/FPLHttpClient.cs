using System;
using System.Net.Http;
using System.Net.Http.Headers;
using FantasyEPL.Sync.Configurations;

namespace FantasyEPL.Sync.Services
{
    public class FPLHttpClient : HttpClient
    {
        public FPLHttpClient(OverTheWireOptions options) : base()
        {
            this.BaseAddress = new Uri(options.BaseUri);
            this.DefaultRequestHeaders.Accept.Clear();
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
