using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public abstract class EntityTypeConfiguration<TEntity>
        where TEntity : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(i => i.Id);
        }
    }
}
