using GamingStoreTekrar.Entities;
using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.Areas.admin_panel.Models
{
    public class CreateGameModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        [Required]
        public IFormFile GameImage { get; set; }
        [Required]
        public double Price { get; set; }
        public string[] Genres { get; set; }
        public string[] Tags { get; set; }
    }
}
