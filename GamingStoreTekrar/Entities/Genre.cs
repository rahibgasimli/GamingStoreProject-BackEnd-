namespace GamingStoreTekrar.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}
