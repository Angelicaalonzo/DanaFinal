using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DanaFinalProject.Models
{
    public class Book
    {
        public int ID { get; set; } // Primary key for Movie. We usually do "MovieId" but "ID" works also
        
       
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
      
        public string Rating { get; set; }

        public List<Review> Reviews {get; set;} // Navigation property. Each movie can have many reviews
        public Author Author {get; set;}
    }
}