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
                        Price = 9.95
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
                        Price = 14.58
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
                        Price = 21.54
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
                        Price = 11.61
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
                        Price = 13.33
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
                        Price = 15.95
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
                        Price = 14.99
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
                        Price = 21.66
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
                        Price = 29.16
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
                        Price = 15.03
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
