namespace FantasyEPL.Data.Entities
{
    public class TeamEntity : EntityBase
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int TeamDivision { get; set; }
    }
}
