using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FantasyEPL.Data;

namespace FantasyEPL.Data.Migrations
{
    [DbContext(typeof(FantasyEPLContext))]
    partial class FantasyEPLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FantasyEPL.Data.Entities.EventEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AverageEntryScore");

                    b.Property<bool>("DataChecked")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime>("DeadlineTime");

                    b.Property<long?>("DeadlineTimeEpoch");

                    b.Property<int?>("DeadlineTimeGameOffset");

                    b.Property<bool>("Finished")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int?>("HighestScore");

                    b.Property<long?>("HighestScoringEntry");

                    b.Property<int>("IsCurrent")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("IsNext")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("IsPrevious")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.PlayerByEventEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Assists")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("BPS")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Bonus")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("ChanceOfPlayingNextRound")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("ChanceOfPlayingThisRound")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("CleanSheets")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int?>("CostChangeEvent");

                    b.Property<int?>("CostChangeEventFall");

                    b.Property<int?>("CostChangeStart");

                    b.Property<int?>("CostChangeStartFall");

                    b.Property<double>("Creativity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int?>("DreamteamCount");

                    b.Property<int?>("EAIndex");

                    b.Property<double?>("EpNext")
                        .HasColumnType("decimal(7, 1)");

                    b.Property<double?>("EpThis")
                        .HasColumnType("decimal(7, 1)");

                    b.Property<int>("EventId");

                    b.Property<int>("EventPoints")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<double>("Form")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int>("GoalsConceded")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("GoalsScored")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<double>("ICTIndex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<bool?>("InDreamteam");

                    b.Property<double>("Influence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int?>("LoanedIn");

                    b.Property<int?>("LoanedOut");

                    b.Property<int?>("LoansIn");

                    b.Property<int?>("LoansOut");

                    b.Property<int>("Minutes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("News");

                    b.Property<int>("NowCost")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("OwnGoals")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("PenaltiesMissed")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("PenaltiesSaved")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("PlayerId");

                    b.Property<double>("PointsPerGame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int>("PositionId");

                    b.Property<int>("RedCards")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Saves")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<double>("SelectedByPercent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<bool?>("Special");

                    b.Property<int>("SquadNumber");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("TeamCode");

                    b.Property<int>("TeamId");

                    b.Property<double>("Threat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int>("TotalPoints")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int?>("TransfersIn");

                    b.Property<int?>("TransfersInEvent");

                    b.Property<int?>("TransfersOut");

                    b.Property<int?>("TransfersOutEvent");

                    b.Property<double?>("ValueForm")
                        .HasColumnType("decimal(7, 1)");

                    b.Property<double?>("ValueSeason")
                        .HasColumnType("decimal(7, 1)");

                    b.Property<int>("YellowCards")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.HasIndex("PlayerId", "EventId")
                        .IsUnique();

                    b.ToTable("PlayersByEvents");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.PlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("FirstName")
                        .HasColumnType("nchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SecondName")
                        .HasColumnType("nchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("WebName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.PlayerPositionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.TeamByEventEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<double>("Form")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(7, 1)")
                        .HasDefaultValue(0.0);

                    b.Property<int>("GameDraw")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("GameLoss")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("GamePlayed")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("GameWin")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Point")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Position")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int?>("Strength");

                    b.Property<int?>("StrengthAttackAway");

                    b.Property<int?>("StrengthAttackHome");

                    b.Property<int?>("StrengthDefenceAway");

                    b.Property<int?>("StrengthDefenceHome");

                    b.Property<int?>("StrengthOverallAway");

                    b.Property<int?>("StrengthOverallHome");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TeamId", "EventId")
                        .IsUnique();

                    b.ToTable("TeamsByEvents");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.TeamEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TeamDivision")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.PlayerByEventEntity", b =>
                {
                    b.HasOne("FantasyEPL.Data.Entities.EventEntity", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FantasyEPL.Data.Entities.PlayerEntity", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FantasyEPL.Data.Entities.PlayerPositionEntity", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FantasyEPL.Data.Entities.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FantasyEPL.Data.Entities.TeamByEventEntity", b =>
                {
                    b.HasOne("FantasyEPL.Data.Entities.EventEntity", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FantasyEPL.Data.Entities.TeamEntity", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
