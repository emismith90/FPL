using Antares.Essentials.Data.UoW;

namespace FantasyEPL.Data
{
    public class FPLUnitOfWork : UnitOfWork
    {
        public FPLUnitOfWork(FPLContext context) : base(context)
        {
        }
    }
}
