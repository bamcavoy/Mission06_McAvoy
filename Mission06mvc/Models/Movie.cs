using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06mvc.Models
{

    //Movie class
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set;}

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; } 
        public string Title { get; set;}

        [Range(1888, int.MaxValue, ErrorMessage = "Year cannot be lower than 1888")]
        public int Year { get; set;}
        public string? Director { get; set;}
        public string? Rating { get; set;}
        public int Edited { get; set;}
        public string? LentTo { get; set;}
        public int CopiedToPlex { get; set;}
        public string? Notes { get; set;}
    }
}
