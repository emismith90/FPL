using System;
using Microsoft.EntityFrameworkCore.Storage;

namespace FantasyEPL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FantasyEPLContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(FantasyEPLContext context)
        {
            _context = context;
        }
        public IUnitOfWork BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
            return this;
        }

        public bool EndTransaction()
        {
            _context.SaveChanges();
            _transaction.Commit();

            return true;
        }
        public IUnitOfWork Commit()
        {
            _context.SaveChanges();
            return this;
        }

        public void RollBack()
        {
            _transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
