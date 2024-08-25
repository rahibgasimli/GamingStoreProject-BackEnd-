using GamingStoreTekrar.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Areas.admin_panel.Models
{
    public class EditUserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public byte Age { get; set; }
        public string PhotoPath { get; set; }
        public IFormFile? ProfilePhoto { get; set; }
    }
}
