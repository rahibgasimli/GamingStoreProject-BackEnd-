using GamingStoreTekrar.Models;

namespace GamingStoreTekrar.ViewModels
{
    public class GamesFilterVm
    {
        public List<GamesIndex>? Games { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public string CurrentFilter { get; set; }
    }
}
