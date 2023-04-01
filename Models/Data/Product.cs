using System.ComponentModel.DataAnnotations;

namespace Filmzy.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? price { get; set; }
        public string? image { get; set; }

       
    }
}
