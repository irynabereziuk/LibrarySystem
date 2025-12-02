using System;

namespace LibrarySystem
{
    internal class ReservationService : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[ReservationService] {message}");
        }
    }
}