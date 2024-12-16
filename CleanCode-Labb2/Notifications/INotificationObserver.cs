using CleanCode_Labb2.Models;

namespace CleanCode_Labb2.Notifications
{
    public interface INotificationObserver
    {
        void Update(Books books);
    }
}
