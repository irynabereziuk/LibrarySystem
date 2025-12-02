using System;

namespace LibrarySystem
{
    
    internal class ReaderNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[ReaderNotifier] {message}");
        }
    }
}