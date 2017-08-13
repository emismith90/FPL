using Antares.Essentials.Data.Entities;

namespace FantasyEPL.Data.Entities
{
    public class PlayerByEventEntity : EntityBase
    {
        public int PlayerId { get; set; }
        public int EventId { get; set; }

        public int TeamCode { get; set; }
        public int TeamId { get; set; }

        public int PositionId { get; set; }

        public int SquadNumber { get; set; }

        public string Status { get; set; }
        public string News { get; set; }

        public int NowCost { get; set; }
        public int ChanceOfPlayingThisRound { get; set; }
        public int ChanceOfPlayingNextRound { get; set; }
        public decimal? ValueForm { get; set; }
        public decimal? ValueSeason { get; set; }
        public int? CostChangeStart { get; set; }
        public int? CostChangeEvent { get; set; }
        public int? CostChangeStartFall { get; set; }
        public int? CostChangeEventFall { get; set; }

        public bool? InDreamteam { get; set; }
        public int? DreamteamCount { get; set; }

        public decimal SelectedByPercent { get; set; }
        public decimal Form { get; set; }

        public int? TransfersOut { get; set; }
        public int? TransfersIn { get; set; }
        public int? TransfersOutEvent { get; set; }
        public int? TransfersInEvent { get; set; }
        public int? LoansIn { get; set; }
        public int? LoansOut { get; set; }
        public int? LoanedIn { get; set; }
        public int? LoanedOut { get; set; }

        public int TotalPoints { get; set; }
        public int EventPoints { get; set; }
        public decimal PointsPerGame { get; set; }

        public decimal? EpThis { get; set; }
        public decimal? EpNext { get; set; }
        public bool? Special { get; set; }

        public int Minutes { get; set; }
        public int GoalsScored { get; set; }
        public int Assists { get; set; }
        public int CleanSheets { get; set; }
        public int GoalsConceded { get; set; }
        public int OwnGoals { get; set; }
        public int PenaltiesSaved { get; set; }
        public int PenaltiesMissed { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Saves { get; set; }
        public int Bonus { get; set; }
        public int BPS { get; set; }

        public decimal Influence { get; set; }
        public decimal Creativity { get; set; }
        public decimal Threat { get; set; }
        public decimal ICTIndex { get; set; }
        public int? EAIndex { get; set; }

        public virtual PlayerEntity Player { get; set; }
        public virtual EventEntity Event { get; set; }
        public virtual PlayerPositionEntity Position { get; set; }
        public virtual TeamEntity Team { get; set; }
    }
}
