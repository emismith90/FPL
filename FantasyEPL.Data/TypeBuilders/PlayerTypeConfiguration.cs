using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.TypeBuilders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public class PlayerTypeConfiguration : EntityTypeConfiguration<PlayerEntity>
    {
        public override void Configure(EntityTypeBuilder<PlayerEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.WebName)
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(p => p.FirstName)
                .HasColumnType("nchar(255)")
                .HasMaxLength(255);
            builder.Property(p => p.SecondName)
                .HasColumnType("nchar(255)")
                .HasMaxLength(255);

            builder.HasIndex(i => i.Code).IsUnique();
        }
    }
}