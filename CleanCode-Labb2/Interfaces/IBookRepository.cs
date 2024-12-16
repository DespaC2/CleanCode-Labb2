using CleanCode_Labb2.Models;

namespace CleanCode_Labb2.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> GetAllAsync();

        Task AddAsync(Books book);
    }
}
