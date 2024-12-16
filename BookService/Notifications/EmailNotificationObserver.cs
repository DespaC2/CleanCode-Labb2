using BookService.Models;

namespace BookService.Notifications
{
    public class EmailNotificationObserver : INotificationObserver
    {
        public void Update(Books books)
        {
            Console.WriteLine($"Email Notification: New product added - {books.Title}");
        }
    }
}
