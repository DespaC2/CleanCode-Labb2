using CleanCode_Labb2.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanCode_Labb2.Interfaces
{
    public interface IBookDbContext
    {
        DbSet<Books> Books { get; set; }

    }
}
