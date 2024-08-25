using GamingStoreTekrar.Models;

namespace GamingStoreTekrar.ViewModels
{
    public class HomeIndexVm
    {
        public List<GamesIndex> TrendingGames { get; set; }
        public List<string> TopGenres { get; set; }
    }
}
