using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FantasyEPL.Data.Entities;
using FantasyEPL.Data.Extensions;
using FantasyEPL.Data.TypeBuilders;

namespace FantasyEPL.Data
{
    public class FantasyEPLContext : DbContext
    {
        public DbSet<EventEntity> Events { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<TeamByEventEntity> TeamsByEvents { get; set; }
        public DbSet<PlayerPositionEntity> PlayerPositions { get; set; }
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<PlayerByEventEntity> PlayersByEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new EventTypeConfiguration());
            modelBuilder.AddConfiguration(new TeamTypeConfiguration());
            modelBuilder.AddConfiguration(new TeamByEventTypeConfiguration());
            modelBuilder.AddConfiguration(new PlayerPositionTypeConfiguration());
            modelBuilder.AddConfiguration(new PlayerTypeConfiguration());
            modelBuilder.AddConfiguration(new PlayerByEventTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var config = builder.Build();
            optionsBuilder.UseSqlServer(config["ConnectionString"]);
        }
    }
}
