using System;

namespace FantasyEPL.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUnitOfWork Commit();
        IUnitOfWork BeginTransaction();
        bool EndTransaction();
        void RollBack();
    }
}
