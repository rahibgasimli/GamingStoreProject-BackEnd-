using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Areas.admin_panel.Models
{
    public class CreateGenreModel
    {
        [Required]
        public string Name { get; set; }
    }
}
