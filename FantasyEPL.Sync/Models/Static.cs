using System.Collections.Generic;

namespace FantasyEPL.Sync.Models
{
    public class Static
    {
        public IList<Phase> Phases { get; set; }
        public IList<Element> Elements { get; set; }
        public IList<Team> Teams { get; set; }
        public IList<ElementType> ElementTypes { get; set; }
        public IList<Event> Events { get; set; }
    }
}
