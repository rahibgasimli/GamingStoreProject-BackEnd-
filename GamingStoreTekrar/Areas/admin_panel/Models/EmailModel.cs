using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Areas.admin_panel.Models
{
    public class EmailModel
    {
        [EmailAddress]
        public string Recepient { get; set; }
        [Required]
        [MaxLength(80,ErrorMessage ="Too long for subject name")]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

    }
}
