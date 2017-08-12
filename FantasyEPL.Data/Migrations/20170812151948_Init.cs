using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FantasyEPL.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageEntryScore = table.Column<int>(nullable: true),
                    DataChecked = table.Column<bool>(nullable: false, defaultValue: false),
                    DeadlineTime = table.Column<DateTime>(nullable: false),
                    DeadlineTimeEpoch = table.Column<long>(nullable: true),
                    DeadlineTimeGameOffset = table.Column<int>(nullable: true),
                    Finished = table.Column<bool>(nullable: false, defaultValue: false),
                    HighestScore = table.Column<int>(nullable: true),
                    HighestScoringEntry = table.Column<long>(nullable: true),
                    IsCurrent = table.Column<int>(nullable: false, defaultValue: 0),
                    IsNext = table.Column<int>(nullable: false, defaultValue: 0),
                    IsPrevious = table.Column<int>(nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "nchar(255)", maxLength: 255, nullable: true),
                    SecondName = table.Column<string>(type: "nchar(255)", maxLength: 255, nullable: true),
                    WebName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortName = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortName = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    TeamDivision = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayersByEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assists = table.Column<int>(nullable: false, defaultValue: 0),
                    BPS = table.Column<int>(nullable: false, defaultValue: 0),
                    Bonus = table.Column<int>(nullable: false, defaultValue: 0),
                    ChanceOfPlayingNextRound = table.Column<int>(nullable: false, defaultValue: 0),
                    ChanceOfPlayingThisRound = table.Column<int>(nullable: false, defaultValue: 0),
                    CleanSheets = table.Column<int>(nullable: false, defaultValue: 0),
                    CostChangeEvent = table.Column<int>(nullable: true),
                    CostChangeEventFall = table.Column<int>(nullable: true),
                    CostChangeStart = table.Column<int>(nullable: true),
                    CostChangeStartFall = table.Column<int>(nullable: true),
                    Creativity = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    DreamteamCount = table.Column<int>(nullable: true),
                    EAIndex = table.Column<int>(nullable: true),
                    EpNext = table.Column<double>(type: "decimal(7, 1)", nullable: true),
                    EpThis = table.Column<double>(type: "decimal(7, 1)", nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    EventPoints = table.Column<int>(nullable: false, defaultValue: 0),
                    Form = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    GoalsConceded = table.Column<int>(nullable: false, defaultValue: 0),
                    GoalsScored = table.Column<int>(nullable: false, defaultValue: 0),
                    ICTIndex = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    InDreamteam = table.Column<bool>(nullable: true),
                    Influence = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    LoanedIn = table.Column<int>(nullable: true),
                    LoanedOut = table.Column<int>(nullable: true),
                    LoansIn = table.Column<int>(nullable: true),
                    LoansOut = table.Column<int>(nullable: true),
                    Minutes = table.Column<int>(nullable: false, defaultValue: 0),
                    News = table.Column<string>(nullable: true),
                    NowCost = table.Column<int>(nullable: false, defaultValue: 0),
                    OwnGoals = table.Column<int>(nullable: false, defaultValue: 0),
                    PenaltiesMissed = table.Column<int>(nullable: false, defaultValue: 0),
                    PenaltiesSaved = table.Column<int>(nullable: false, defaultValue: 0),
                    PlayerId = table.Column<int>(nullable: false),
                    PointsPerGame = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    PositionId = table.Column<int>(nullable: false),
                    RedCards = table.Column<int>(nullable: false, defaultValue: 0),
                    Saves = table.Column<int>(nullable: false, defaultValue: 0),
                    SelectedByPercent = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    Special = table.Column<bool>(nullable: true),
                    SquadNumber = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    TeamCode = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Threat = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    TotalPoints = table.Column<int>(nullable: false, defaultValue: 0),
                    TransfersIn = table.Column<int>(nullable: true),
                    TransfersInEvent = table.Column<int>(nullable: true),
                    TransfersOut = table.Column<int>(nullable: true),
                    TransfersOutEvent = table.Column<int>(nullable: true),
                    ValueForm = table.Column<double>(type: "decimal(7, 1)", nullable: true),
                    ValueSeason = table.Column<double>(type: "decimal(7, 1)", nullable: true),
                    YellowCards = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersByEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayersByEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayersByEvents_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayersByEvents_PlayerPositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "PlayerPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayersByEvents_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamsByEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    Form = table.Column<double>(type: "decimal(7, 1)", nullable: false, defaultValue: 0.0),
                    GameDraw = table.Column<int>(nullable: false, defaultValue: 0),
                    GameLoss = table.Column<int>(nullable: false, defaultValue: 0),
                    GamePlayed = table.Column<int>(nullable: false, defaultValue: 0),
                    GameWin = table.Column<int>(nullable: false, defaultValue: 0),
                    Point = table.Column<int>(nullable: false, defaultValue: 0),
                    Position = table.Column<int>(nullable: false, defaultValue: 0),
                    Strength = table.Column<int>(nullable: true),
                    StrengthAttackAway = table.Column<int>(nullable: true),
                    StrengthAttackHome = table.Column<int>(nullable: true),
                    StrengthDefenceAway = table.Column<int>(nullable: true),
                    StrengthDefenceHome = table.Column<int>(nullable: true),
                    StrengthOverallAway = table.Column<int>(nullable: true),
                    StrengthOverallHome = table.Column<int>(nullable: true),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsByEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamsByEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsByEvents_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayersByEvents_EventId",
                table: "PlayersByEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersByEvents_PositionId",
                table: "PlayersByEvents",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersByEvents_TeamId",
                table: "PlayersByEvents",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersByEvents_PlayerId_EventId",
                table: "PlayersByEvents",
                columns: new[] { "PlayerId", "EventId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Code",
                table: "Players",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamsByEvents_EventId",
                table: "TeamsByEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsByEvents_TeamId_EventId",
                table: "TeamsByEvents",
                columns: new[] { "TeamId", "EventId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Code",
                table: "Teams",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersByEvents");

            migrationBuilder.DropTable(
                name: "TeamsByEvents");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PlayerPositions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
