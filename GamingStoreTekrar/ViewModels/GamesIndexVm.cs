using GamingStoreTekrar.Models;

namespace GamingStoreTekrar.ViewModels
{
    public class GamesIndexVm
    {
        public List<GamesIndex>? Games { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public List<GenreModel> Genres { get; set; }

    }
}
