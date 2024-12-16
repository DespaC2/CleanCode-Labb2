using BookService.Models;

namespace BookService.Notifications
{
    public interface INotificationObserver
    {
        void Update(Books books);
    }
}
