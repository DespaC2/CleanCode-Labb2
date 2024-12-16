using BookService.Interfaces;
using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Data
{
    public class BookDbContext : DbContext, IBookDbContext
    {
        public DbSet<Books> Books { get; set; }
        
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {

        }
    }
}
