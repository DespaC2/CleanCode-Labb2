using CleanCode_Labb2.Models;

namespace CleanCode_Labb2.Notifications
{
    public class EmailNotificationObserver : INotificationObserver
    {
        public void Update(Books books)
        {
            Console.WriteLine($"Email Notification: New product added - {books.Title}");
        }
    }
}
