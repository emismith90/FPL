using Antares.Essentials.Data.Repositories;
using Antares.Essentials.Data.Entities;

namespace FantasyEPL.Data
{
    public class FPLGenericRepository<TEntity> : GenericRepository<TEntity>, IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        public FPLGenericRepository(FPLContext context) : base(context)
        {
        }
    }
}
