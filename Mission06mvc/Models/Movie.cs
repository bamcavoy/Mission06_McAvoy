using System.ComponentModel.DataAnnotations;

namespace Mission06mvc.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set;}
        public string MovieTitle { get; set;}
        [Range(1900, 2050)]
        public int MovieYear { get; set;}
        public string MovieDirector { get; set;}
        public string MovieCategory { get; set;}
        public string MovieRating { get; set;}
        public bool MovieEdited { get; set;}
        public string MovieLentTo { get; set;}
        [Length(0,25)]
        public string MovieNotes { get; set;}


    }
}
