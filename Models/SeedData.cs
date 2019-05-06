using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using DanaFinalProject.Models;
using System.Collections.Generic;

namespace DanaFinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookDbContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    },

                    new Book
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    },

                    new Book
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        },
                        Author = new Author{
                            FirstName = "Anne",
                            LastName = "Smith"
                        }
                    },

                    new Book
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 1},
                            new Review {Score = 5}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}