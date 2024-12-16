using BookService.Data;
using BookService.Interfaces;
using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Books>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task AddAsync(Books books)
        {
            await _context.Books.AddAsync(books);
        }




    }
}
