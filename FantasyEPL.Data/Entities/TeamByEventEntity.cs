using Antares.Essentials.Data.Entities;

namespace FantasyEPL.Data.Entities
{
    public class TeamByEventEntity : EntityBase
    {
        public int TeamId { get; set; }
        public int EventId { get; set; }

        public int Position { get; set; }
        public int Point { get; set; }
        public int GamePlayed { get; set; }
        public int GameWin { get; set; }
        public int GameLoss { get; set; }
        public int GameDraw { get; set; }
        public int? Strength { get; set; }
        public int? StrengthOverallHome { get; set; }
        public int? StrengthOverallAway { get; set; }
        public int? StrengthAttackHome { get; set; }
        public int? StrengthAttackAway { get; set; }
        public int? StrengthDefenceHome { get; set; }
        public int? StrengthDefenceAway { get; set; }
        public decimal Form { get; set; }

        public virtual TeamEntity Team { get; set; }
        public virtual EventEntity Event { get; set; }
    }
}
