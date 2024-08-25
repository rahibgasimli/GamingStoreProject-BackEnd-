using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamingStoreTekrar.Entities
{
    public class AppUser : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public byte Age { get; set; }
        public string ProfilePhoto { get; set; }
        [NotMapped]
        public string FullName { get => FName + " " + LName; }
    }
}
