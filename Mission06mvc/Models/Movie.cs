using System.ComponentModel.DataAnnotations;

namespace Mission06mvc.Models
{

    //Movie class
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set;}
        public int CategoryID { get; set; }
        public string Title { get; set;}
        public int Year { get; set;}
        public string Director { get; set;}
        public string Rating { get; set;}
        public int Edited { get; set;}
        public string LentTo { get; set;}
        public int CopiedToPlex { get; set;}
        public string Notes { get; set;}
    }

    public class Category
    {
        [Key]
        [Required]
        public intCategoryID 
    }
}
