using FantasyEPL.Sync.Models;
using System.Threading.Tasks;

namespace FantasyEPL.Sync.Services
{
    public interface IFPLDataProvider
    {
        Task<Static> GetStaticData();
    }
}
