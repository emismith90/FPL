using System;

namespace FantasyEPL.Sync.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeadlineTime { get; set; }
        public int AverageEntryScore { get; set; }
        public bool Finished { get; set; }
        public bool DataChecked { get; set; }
        public long? HighestScoringEntry { get; set; }
        public long? DeadlineTimeEpoch { get; set; }
        public int? DeadlineTimeGameOffset { get; set; }
        public string DeadlineTimeFormatted { get; set; }
        public int? HighestScore { get; set; }
        public bool IsPrevious { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsNext { get; set; }
    }
}
