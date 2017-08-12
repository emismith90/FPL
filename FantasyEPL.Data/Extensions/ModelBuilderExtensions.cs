using Microsoft.EntityFrameworkCore;
using FantasyEPL.Data.Entities;
using FantasyEPL.Data.TypeBuilders;

namespace FantasyEPL.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
            where TEntity : EntityBase
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }
    }
}
