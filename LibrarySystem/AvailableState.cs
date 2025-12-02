using System;

namespace LibrarySystem
{
    internal class AvailableState : ILibraryItemState
    {
        public void Lend(LibraryItem item)
        {
            Console.WriteLine($"'{item.Title}' видана користувачу.");
            item.SetState(new OnLoanState());
        }

        public void Return(LibraryItem item) => Console.WriteLine($"'{item.Title}' вже доступна.");
        public void Reserve(LibraryItem item)
        {
            Console.WriteLine($"'{item.Title}' зарезервована.");
            item.SetState(new ReservedState());
        }
    }
}