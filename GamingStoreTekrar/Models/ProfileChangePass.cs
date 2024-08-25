using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Models
{
    public class ProfileChangePass
    {
        public string Id { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
