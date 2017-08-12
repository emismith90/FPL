using Microsoft.Extensions.Configuration;
using Antares.Essentials.Configuration;

namespace FantasyEPL.Sync.Configurations
{
    public interface IFileLocator
    {
        string DefaultFile { get; }
    }

    public class LocalOptions : OptionsBase, IFileLocator
    {
        public LocalOptions(IConfiguration scope) : base(scope)
        {
        }

        public string DefaultFile => GetString();
    }
}
