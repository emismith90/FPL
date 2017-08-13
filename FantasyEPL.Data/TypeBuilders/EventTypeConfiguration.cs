using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FantasyEPL.Data.Entities;

namespace FantasyEPL.Data.TypeBuilders
{
    public class EventTypeConfiguration : FPLEntityTypeConfiguration<EventEntity>
    {
        public override void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Finished).HasDefaultValue(false).IsRequired();
            builder.Property(p => p.DataChecked).HasDefaultValue(false).IsRequired();
            builder.Property(p => p.IsPrevious).HasDefaultValue(false).IsRequired();
            builder.Property(p => p.IsCurrent).HasDefaultValue(false).IsRequired();
            builder.Property(p => p.IsNext).HasDefaultValue(false).IsRequired();

            builder.Property(p => p.DeadlineTime)
                .IsRequired();
        }
    }
}
