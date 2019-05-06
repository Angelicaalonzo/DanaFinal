using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DanaFinalProject.Models;

namespace DanaFinalProject.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly DanaFinalProject.Models.BookDbContext _context;

        public IndexModel(DanaFinalProject.Models.BookDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}