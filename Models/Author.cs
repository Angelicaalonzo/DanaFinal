using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DanaFinalProject.Models
{
    public class Author
    {
        public int ID { get; set; } // Primary key 
        
        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int BookID {get;set;} //FK

        public List<Book> Books {get; set;} // Navigation property. Each Author can have many Books

        
      
        

       
    }
}