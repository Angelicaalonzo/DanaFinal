using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using DanaFinalProject.Models;



namespace DanaFinalProject.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger _log;

        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;}

        [BindProperty]
        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "The E-Mail field is not valid.")]
        public string Email {get; set;}

       

        public ContactModel(ILogger<ContactModel> log)
        {
            _log = log;
        }
        public void OnPost()
        {
             _log.LogWarning("OnPost() Called");
        }
        public void OnGet()
        {

        }
        

       
    }
}