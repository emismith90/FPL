using FantasyEPL.Sync.Models;
using System.Threading.Tasks;

namespace FantasyEPL.Sync.Services
{
    public interface IFPLDataProviderService
    {
        Task<Static> GetStaticDataAsync();
    }
}
