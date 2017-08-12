using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.TypeBuilders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public class TeamByEventTypeConfiguration : EntityTypeConfiguration<TeamByEventEntity>
    {
        public override void Configure(EntityTypeBuilder<TeamByEventEntity> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Position).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.Point).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GamePlayed).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GameWin).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GameLoss).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GameDraw).HasDefaultValue(0).IsRequired();

            builder.Property(p => p.Form)
                .HasColumnType("decimal(7, 1)")
                .HasDefaultValue(0.0)
                .IsRequired();

            builder.HasOne(m => m.Team)
                .WithMany()
                .HasForeignKey(m => m.TeamId)
                .IsRequired();
            builder.HasOne(m => m.Event)
                .WithMany()
                .HasForeignKey(m => m.EventId)
                .IsRequired();

            builder.HasIndex(p => new { p.TeamId, p.EventId }).IsUnique();
        }
    }
}
