namespace GamingStoreTekrar.Models
{
    public class SearchModel
    {
        public List<GamesIndex> FoundGames { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public string Query { get; set; }
    }
}
