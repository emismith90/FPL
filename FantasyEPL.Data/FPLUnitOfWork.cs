using Antares.Essentials.Data.UoW;

namespace FantasyEPL.Data
{
    public class FPLUnitOfWork : UnitOfWork, IUnitOfWork
    {
        public FPLUnitOfWork(FPLContext context) : base(context)
        {
        }
    }
}
