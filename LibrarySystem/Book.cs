using System;
using System.Collections.Generic;

namespace LibrarySystem
{
   
    internal class Book : LibraryItem, ICanBeTakenHome
    {
        private List<IObserver> _observers = new();

        public string Author { get; private set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        
        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }

        public void ReturnBook()
        {
            ReturnItem();
            NotifyObservers($"Книга '{Title}' повернена в бібліотеку.");
        }

       
        public void ReserveBook()
        {
            NotifyObservers($"Книга '{Title}' зарезервована.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}");
        }
    }
}