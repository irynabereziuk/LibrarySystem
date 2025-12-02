using System;

namespace LibrarySystem
{
    internal class ReservedState : ILibraryItemState
    {
        public void Lend(LibraryItem item)
        {
            Console.WriteLine($"'{item.Title}' видана з резерву.");
            item.SetState(new OnLoanState());
        }

        public void Return(LibraryItem item) => Console.WriteLine($"'{item.Title}' повернена і ще зарезервована.");
        public void Reserve(LibraryItem item) => Console.WriteLine($"'{item.Title}' вже зарезервована.");
    }
}