using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Areas.admin_panel.Models
{
    public class CreateTagModel
    {
        [Required]
        public string Name { get; set; }
    }
}
