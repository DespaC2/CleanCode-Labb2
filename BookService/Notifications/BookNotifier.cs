using BookService.Models;

namespace BookService.Notifications
{
    public class BookNotifier
    {
        private readonly List<INotificationObserver> _observers = new();

        public void Attach(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Books books)
        {
            foreach (var observer in _observers)
            {
                observer.Update(books);
            }
        }





    }
}
