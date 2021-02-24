using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BooksDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    // Load up all of the data to be stored in the database at first
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirst = "Victor",
                        AuthLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageNum = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthFirst = "Doris",
                        AuthMid = "Kearns",
                        AuthLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageNum = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthFirst = "Alice",
                        AuthLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageNum = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthFirst = "Ronald",
                        AuthMid = "C.",
                        AuthLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageNum = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthFirst = "Laura Hillenbrand",
                        AuthLast = "",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        PageNum = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthFirst = "Michael Crichton",
                        AuthLast = "",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        PageNum = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthFirst = "Cal Newport",
                        AuthLast = "",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageNum = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthFirst = "Michael Abrashoff",
                        AuthLast = "",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        PageNum = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthFirst = "Richard Branson",
                        AuthLast = "",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        PageNum = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthFirst = "John Grisham",
                        AuthLast = "",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        PageNum = 642
                    },
                    new Book
                    {
                        Title = "Foundation",
                        AuthFirst = "Isaac",
                        AuthLast = "Asimov",
                        Publisher = "Bantam",
                        ISBN = "978-0553293357",
                        Classification = "Science-Fiction",
                        Category = "Political Drama",
                        Price = 3.85,
                        PageNum = 244
                    },
                    new Book
                    {
                        Title = "The Alchemist",
                        AuthFirst = "Paulo",
                        AuthLast = "Coelho",
                        Publisher = "HarperTorch",
                        ISBN = "978-0061122415",
                        Classification = "Adventure-Fiction",
                        Category = "Quest",
                        Price = 20.29,
                        PageNum = 197
                    },
                    new Book
                    {
                        Title = "The Millionaire Next Door: The Surprising Secrets of America's Wealthy",
                        AuthFirst = "Thomas",
                        AuthMid = "J.",
                        AuthLast = "Stanley",
                        Publisher = "Taylor Trade",
                        ISBN = "978-1589795471",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 10.29,
                        PageNum = 272
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
