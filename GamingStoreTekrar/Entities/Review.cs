namespace GamingStoreTekrar.Entities
{
    public class Review : BaseEntity
    {
        public string ReviewText { get; set; }
        public AppUser User { get; set; }
        public Game Game { get; set; }
    }
}
