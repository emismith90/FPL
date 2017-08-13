using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.Entities;
using Antares.Essentials.Data.TypeBuilders;

namespace FantasyEPL.Data.TypeBuilders
{
    public abstract class FPLEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
        }
    }
}
