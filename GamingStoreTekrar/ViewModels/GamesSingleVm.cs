using GamingStoreTekrar.Models;

namespace GamingStoreTekrar.ViewModels
{
    public class GamesSingleVm
    {
        public GamesSingleModel GameDetails { get; set; }
        public List<RelatedGame> RelatedGames { get; set; }
    }

    public class RelatedGame
    {
        public string Id { get; set; }
        public string Genre { get; set; }
        public string PhotoPath { get; set; }
    }
}
