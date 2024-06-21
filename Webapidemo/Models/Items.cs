using System.ComponentModel.DataAnnotations;

namespace Webapidemo.Models
{
    public class Items
    {
        public int Id { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }
        public string Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        public double Price { get; set; }

    } 
}
