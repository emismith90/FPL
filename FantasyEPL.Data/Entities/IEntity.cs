namespace FantasyEPL.Data.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}
