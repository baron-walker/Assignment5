using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookRepository : iBooksRepository
    {
        private BooksDbContext _context;

        // Constructor
        public EFBookRepository (BooksDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
