using System;

namespace FantasyEPL.Data.Entities
{
    public class EventEntity : EntityBase
    {
        public string Name { get; set; }
        public DateTime DeadlineTime { get; set; }
        public int? AverageEntryScore { get; set; }
        public bool Finished { get; set; }
        public bool DataChecked { get; set; }
        public long? HighestScoringEntry { get; set; }
        public long? DeadlineTimeEpoch { get; set; }
        public int? DeadlineTimeGameOffset { get; set; }
        public int? HighestScore { get; set; }
        public int IsPrevious { get; set; }
        public int IsCurrent { get; set; }
        public int IsNext { get; set; }
    }
}
