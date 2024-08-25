using GamingStoreTekrar.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Models
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Range(0, 255)]
        public byte Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare(nameof(ConfirmPassword))]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        [FileValidator(AcceptedTypes = ".png, .jpg, .jpeg, .svg")]
        public IFormFile ProfilePhoto { get; set; }
    }
}
