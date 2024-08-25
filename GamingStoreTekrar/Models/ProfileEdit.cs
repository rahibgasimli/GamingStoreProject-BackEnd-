namespace GamingStoreTekrar.Models
{
    public class ProfileEdit
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
}
