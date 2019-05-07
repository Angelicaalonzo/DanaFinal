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
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(

                   new Book
                    {
                        Title = "In the Country",
                        ReleaseDate = DateTime.Parse("2015-6-16"),
                        Genre = "Contemporary",
                        Price = 7.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 3},
                            new Review {Score = 5}
                        },
                        Author = new Author{
                                        FirstName = "Mia ",
                                        LastName = "Alvar"
                        }

                        },

                    new Book
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        ReleaseDate = DateTime.Parse("1997-6-26"),
                        Genre = "Fantasy",
                        Price = 8.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 5},
                            new Review {Score = 5}
                        },
                            Author = new Author{
                                            FirstName = "J.K. ",
                                            LastName = "Rowling"
                            }

                        },

                        new Book
                        {
                            Title = "Harry Potter and the Chamber of Secrets",
                            ReleaseDate = DateTime.Parse("1998-6-2"),
                            Genre = "Fantasy",
                            Price = 8.99M,
                            Reviews = new List<Review> {
                                new Review {Score = 5},
                                new Review {Score = 5}
                            },
                            Author = new Author{
                                FirstName = "J.K. ",
                                LastName = "Rowling"
                            }

                        },

                        new Book
                        {
                            Title = "Harry Potter and the Prisoner of Azkaban",
                            ReleaseDate = DateTime.Parse("2004-5-1"),
                            Genre = "Fantasy",
                            Price = 10.99M,
                            Reviews = new List<Review> {
                                new Review {Score = 5},
                                new Review {Score = 5}
                            },
                            Author = new Author{
                                FirstName = "J.K. ",
                                LastName = "Rowling"
                            }

                        },

                        new Book
                        {
                            Title = "Harry Potter and the Goblet of Fire",
                            ReleaseDate = DateTime.Parse("2002-9-28"),
                            Genre = "Fantasy",
                            Price = 13.99M,
                            Reviews = new List<Review> {
                                new Review {Score = 5},
                                new Review {Score = 5}
                            },
                            Author = new Author{
                                FirstName = "J.K. ",
                                LastName = "Rowling"
                            }

                        },
                        new Book
                        {
                            Title = "Harry Potter and The Order of The Phoenix",
                            ReleaseDate = DateTime.Parse("2004-9-1"),
                            Genre = "Fantasy",
                            Price = 13.99M,
                            Reviews = new List<Review> {
                                new Review {Score = 5},
                                new Review {Score = 4}
                            },
                        Author = new Author{
                                FirstName = "J.K. ",
                                LastName = "Rowling"
                        }

            },

                    new Book
                    {
                        Title = "Harry Potter and The Half Blood Prince",
                        ReleaseDate = DateTime.Parse("2006-9-16"),
                        Genre = "Fantasy",
                        Price = 13.99M,
                        Reviews = new List<Review> {
                            new Review {Score = 2},
                            new Review {Score = 4}
                        },
                        Author = new Author{
                            FirstName = "J.K. ",
                            LastName = "Rowling"
                        }

                    },

            new Book
                                {
                                    Title = "Harry Potter and The Deathly Hallows",
                                    ReleaseDate = DateTime.Parse("2007-6-21"),
                                    Genre = "Fantasy",
                                    Price = 13.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 1},
                                        new Review {Score = 4}
                                    },
                        Author = new Author{
                                        FirstName = "J.K. ",
                                        LastName = "Rowling"
                        }

            },


            new Book
                                {
                                    Title = "The Farm",
                                    ReleaseDate = DateTime.Parse("2019-5-07"),
                                    Genre = "Contemporary",
                                    Price = 13.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 3},
                                        new Review {Score = 3}
                                    },
                        Author = new Author{
                                        FirstName = "Joanne ",
                                        LastName = "Ramos"
                        }

            },


            new Book
                                {
                                    Title = "The Hunger Games",
                                    ReleaseDate = DateTime.Parse("2008-10-07"),
                                    Genre = "Fantasy",
                                    Price = 13.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 3},
                                        new Review {Score = 3}
                                    },
                        Author = new Author{
                                        FirstName = "Suzanne ",
                                        LastName = "Collins"
                        }

            },

            new Book
                                {
                                    Title = "Catching Fire",
                                    ReleaseDate = DateTime.Parse("2009-9-01"),
                                    Genre = "Fantasy",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 3},
                                        new Review {Score = 3}
                                    },
                        Author = new Author{
                                    FirstName = "Suzanne ",
                                        LastName = "Collins"
                        }

            },

            new Book
                                {
                                    Title = "Mockingjay",
                                    ReleaseDate = DateTime.Parse("2010-9-01"),
                                    Genre = "Fantasy",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 3},
                                        new Review {Score = 3}
                                    },
                        Author = new Author{
                                    FirstName = "Suzanne ",
                                        LastName = "Collins"
                        }

            },

            new Book
                                {
                                    Title = "Girl Wash Your Face",
                                    ReleaseDate = DateTime.Parse("2018-2-01"),
                                    Genre = "Lifestyle",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 1},
                                        new Review {Score = 1}
                                    },
                        Author = new Author{
                                    FirstName = "Rachel ",
                                    LastName = "Hollins"
                        }

            },

            new Book
                                {
                                    Title = "Lord of The Flies",
                                    ReleaseDate = DateTime.Parse("1954-3-01"),
                                    Genre = "Classic",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 5},
                                        new Review {Score = 3}
                                    },
                        Author = new Author{
                                    FirstName = "William",
                                        LastName = "Golding"
                        }

            },

            new Book
                                {
                                    Title = "Treasure Island",
                                    ReleaseDate = DateTime.Parse("1883-2-15"),
                                    Genre = "Classic",
                                    Price = 10.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 5},
                                        new Review {Score = 5}
                                    },
                        Author = new Author{
                                    FirstName = "Robert ",
                                        LastName = "Stevenson"
                        }

            },

            new Book
                                {
                                    Title = "Animal Farm",
                                    ReleaseDate = DateTime.Parse("1945-8-01"),
                                    Genre = "Classic",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 4},
                                        new Review {Score = 2}
                                    },
                        Author = new Author{
                                    FirstName = "George  ",
                                        LastName = "Orwell"
                        }

            },

            new Book
                                {
                                    Title = "To Kill a Mockingbird",
                                    ReleaseDate = DateTime.Parse("1960-11-01"),
                                    Genre = "Classic",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 5},
                                        new Review {Score = 5}
                                    },
                        Author = new Author{
                                    FirstName = "Harper ",
                                        LastName = "Lee"
                        }

            },

            new Book
                                {
                                    Title = "Of Mice and Men",
                                    ReleaseDate = DateTime.Parse("1937-12-01"),
                                    Genre = "Classic",
                                    Price = 20.99M,
                                    Reviews = new List<Review> {
                                        new Review {Score = 4},
                                        new Review {Score = 5}
                                    },
                        Author = new Author{
                                    FirstName = "John ",
                                        LastName = "Steinbeck"
                        }

                        }
                );
                context.SaveChanges();
            }
        }
    }
}