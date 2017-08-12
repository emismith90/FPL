using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.TypeBuilders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public class PlayerByEventTypeConfiguration : EntityTypeConfiguration<PlayerByEventEntity>
    {
        public override void Configure(EntityTypeBuilder<PlayerByEventEntity> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.TeamCode).IsRequired();
            builder.Property(p => p.TeamId).IsRequired();
            builder.Property(p => p.PositionId).IsRequired();
            builder.Property(p => p.SquadNumber).IsRequired();
            builder.Property(p => p.Status).IsRequired();

            builder.Property(p => p.NowCost).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.ChanceOfPlayingThisRound).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.ChanceOfPlayingNextRound).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.ValueForm)
               .HasColumnType("decimal(7, 1)");
            builder.Property(p => p.ValueSeason)
                .HasColumnType("decimal(7, 1)");

            builder.Property(p => p.SelectedByPercent)
                .HasColumnType("decimal(7, 1)")
                .HasDefaultValue(0.0)
                .IsRequired();
            builder.Property(p => p.Form)
                .HasColumnType("decimal(7, 1)")
                .HasDefaultValue(0.0)
                .IsRequired();

            builder.Property(p => p.TotalPoints).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.EventPoints).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.TotalPoints).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.PointsPerGame)
               .HasColumnType("decimal(7, 1)")
               .HasDefaultValue(0.0)
               .IsRequired();

            builder.Property(p => p.EpThis)
              .HasColumnType("decimal(7, 1)");
            builder.Property(p => p.EpNext)
              .HasColumnType("decimal(7, 1)");

            builder.Property(p => p.Minutes).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GoalsScored).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.Assists).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.CleanSheets).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.GoalsConceded).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.OwnGoals).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.PenaltiesSaved).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.PenaltiesMissed).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.YellowCards).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.RedCards).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.Saves).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.Bonus).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.BPS).HasDefaultValue(0).IsRequired();

            builder.Property(p => p.Influence)
               .HasColumnType("decimal(7, 1)")
               .HasDefaultValue(0.0)
               .IsRequired();
            builder.Property(p => p.Creativity)
               .HasColumnType("decimal(7, 1)")
               .HasDefaultValue(0.0)
               .IsRequired();
            builder.Property(p => p.Threat)
               .HasColumnType("decimal(7, 1)")
               .HasDefaultValue(0.0)
               .IsRequired();
            builder.Property(p => p.ICTIndex)
               .HasColumnType("decimal(7, 1)")
               .HasDefaultValue(0.0)
               .IsRequired();

            builder.HasOne(m => m.Player)
               .WithMany()
               .HasForeignKey(m => m.PlayerId)
               .IsRequired();
            builder.HasOne(m => m.Event)
                .WithMany()
                .HasForeignKey(m => m.EventId)
                .IsRequired();
            builder.HasIndex(p => new { p.PlayerId, p.EventId }).IsUnique();

            builder.HasOne(m => m.Team)
                .WithMany()
                .HasForeignKey(m => m.TeamId)
                .IsRequired();
            builder.HasOne(m => m.Position)
                .WithMany()
                .HasForeignKey(m => m.PositionId)
                .IsRequired();
        }
    }
}