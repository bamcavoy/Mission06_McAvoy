using System.ComponentModel.DataAnnotations;

namespace Mission06mvc.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
