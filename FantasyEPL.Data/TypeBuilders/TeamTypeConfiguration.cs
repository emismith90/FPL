using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public class TeamTypeConfiguration : EntityTypeConfiguration<TeamEntity>
    {
        public override void Configure(EntityTypeBuilder<TeamEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(p => p.ShortName)
                .HasColumnType("nchar(10)")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.TeamDivision).HasDefaultValue(1).IsRequired();

            builder.HasIndex(i => i.Code).IsUnique();
            //builder.HasIndex(i => i.Position).IsUnique();
        }
    }
}
