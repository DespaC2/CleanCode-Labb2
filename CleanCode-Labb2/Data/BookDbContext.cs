using CleanCode_Labb2.Interfaces;
using CleanCode_Labb2.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanCode_Labb2.Data
{
    public class BookDbContext : DbContext, IBookDbContext
    {
        public DbSet<Books> Books { get; set; }
        
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {

        }
    }
}
