using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DanaFinalProject.Models
{
    public class Review
    {
        public int ID { get; set; } // Primary key. This is the Review ID

        // Data validation: Score must be between 1 and 5.
        // Score must be required
        [Range(1, 5)]
        [Required]
        public int Score {get; set;}

        [Display(Name = "Movie")]
        [Required]
        public int BookId {get; set;} // Fk
        
        public Book Book {get; set;} // Navigation Property. Each Review goes back to ONE Movie
    }
}