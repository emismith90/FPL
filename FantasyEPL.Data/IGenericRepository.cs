using System;
using System.Linq;
using System.Linq.Expressions;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data
{
     public interface IGenericRepository<TEntity> : IDisposable
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();

        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(int id);

        int SaveChanges();
    }
}
