using System.ComponentModel.DataAnnotations;

namespace Filmzy.Models
{
    public class StoreData
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string logo { get; set; }

        


    }
}
