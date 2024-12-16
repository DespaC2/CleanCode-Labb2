using BookService.Models;
using Microsoft.EntityFrameworkCore;

namespace BookService.Interfaces
{
    public interface IBookDbContext
    {
        DbSet<Books> Books { get; set; }

    }
}
