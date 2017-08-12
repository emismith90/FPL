using Antares.Essentials.Data.Entities;

namespace FantasyEPL.Data.Entities
{
    public class PlayerEntity : EntityBase
    {
        public int Code { get; set; }
        public string WebName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
