using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DanaFinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace DanaFinalProject.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly DanaFinalProject.Models.BookDbContext _context;
        private readonly ILogger _logger;

        public IndexModel(DanaFinalProject.Models.BookDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Book> Book { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        public SelectList SortList {get; set;}
        [BindProperty(SupportsGet = true)]
        public string BookGenre { get; set; }

        // PageSize: How many records to display per page.
        // Default: 10
        public int PageSize {get; set;} = 10;

        // PageNum: Current Page Number we are on. Default is 1
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;

        public int TotalCount {get; set;} // Total number of records
        public int TotalPages {get; set;} // Total number of pages
        
        // String to keep track of our current sort order. Needed for 
        // paging to remember current sort
        public string CurrentSort {get; set;} 
        
        // Next Sort for Title and Date sort. This alternates between asc/desc
        public string TitleSort {get; set;} = "title_asc";
        public string DateSort {get; set;} = "date_asc";

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;

            // Sorting Technique 2. Create a SelectList of sort options.
            // Set the values equal to our expected sort strings
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem {Text = "Title Ascending", Value = "title_asc"},
                new SelectListItem("Title Descending", "title_desc"),
                new SelectListItem("Release Date Ascending", "date_asc"),
                new SelectListItem("Release Date Descending", "date_desc")
            };
            // Default value will be CurrentSort
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);
            
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Book
                                            orderby m.Genre
                                            select m.Genre;

            //var movies = from m in _context.Book
            //            select m;
            // var movies = _context.Book.Include(m => m.Reviews).Select(m => new {
            //     ID = m.ID,
            //     Title = m.Title,
            //     ReleaseDate = m.ReleaseDate,
            //     Genre = m.Genre,
            //     Price = m.Price,
            //     Rating = m.Rating,
            //     Review = m.Reviews.Average(r => r.Score)            
            // });
            // IQueryable<Book> movies = _context.Book.Include(m => m.Reviews);
            // var movies = (from m in _context.Book
            //     select m).Include("Reviews");
            
            // Use .Include() to bring in the reviews
            var movies = _context.Book.Include(m => m.Reviews).Select(m => m);
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(BookGenre))
            {
                movies = movies.Where(x => x.Genre == BookGenre);
            }

            // Calculate total number of records and how many pages that takes
            TotalCount = movies.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            // Do the sorting. This is the brains of sorting
            // Switch on sort Order and perform proper LINQ query
            switch (sortOrder) 
            {
                case "title_desc":
                    _logger.LogInformation("Sorting by Title descending");
                    movies = movies.OrderByDescending(m => m.Title);
                    TitleSort = "title_asc";
                    break;
                case "title_asc":
                    _logger.LogInformation("Sorting by Title ascending");
                    movies = movies.OrderBy(m => m.Title);
                    TitleSort = "title_desc";
                    break;
                case "date_desc":
                    _logger.LogInformation("Sorting by Release Date descending");
                    movies = movies.OrderByDescending(m => m.ReleaseDate);
                    DateSort = "date_asc";
                    break;
                case "date_asc":
                    _logger.LogInformation("Sorting by Release Date ascending");
                    movies = movies.OrderBy(m => m.ReleaseDate);
                    DateSort = "date_desc";
                    break;
                default:
                    _logger.LogInformation("No Sorting");
                    break;
            }

            // Pick the movies for paging. Skip() to current page and then Take the right
            // number of movies
            Book = await movies.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
