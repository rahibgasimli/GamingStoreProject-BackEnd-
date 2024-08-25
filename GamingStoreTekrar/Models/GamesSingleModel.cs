namespace GamingStoreTekrar.Models
{
    public class GamesSingleModel
    {
        public string gameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public string PhotoPath { get; set; }
        public double Price { get; set; }
        public string Genres { get; set; }
        public string GameTags { get; set; }
        public int ClickCount { get; set; }
    }
}
