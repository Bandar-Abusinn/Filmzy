using System.ComponentModel.DataAnnotations;

namespace Filmzy.Models
{
    public class details
    {
        [Key]
        public int Id { get; set; }
        public string? type { get; set; }
        public int duration { get; set; }
        public string? Description { get; set; }
        public string? cast { get; set; }

        public Product product { get; set; }
    }
}
