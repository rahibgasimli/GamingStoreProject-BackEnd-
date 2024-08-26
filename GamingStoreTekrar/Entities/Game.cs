namespace GamingStoreTekrar.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public string PhotoPath { get; set; }
        public double Price { get; set; }
        public int ClickCount { get; set; }
        public List<Genre> Genres { get; set; }
        public List<GameTag> GameTags { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
