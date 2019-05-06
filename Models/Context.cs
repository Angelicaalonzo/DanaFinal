using Microsoft.EntityFrameworkCore;

namespace DanaFinalProject.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<DanaFinalProject.Models.Book> Book { get; set; }

    }
}