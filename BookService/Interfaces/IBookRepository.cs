using BookService.Models;

namespace BookService.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> GetAllAsync();

        Task AddAsync(Books book);
    }
}
