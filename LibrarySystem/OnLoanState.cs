using System;

namespace LibrarySystem
{
    internal class OnLoanState : ILibraryItemState
    {
        public void Lend(LibraryItem item) => Console.WriteLine($"'{item.Title}' вже видана!");
        public void Return(LibraryItem item)
        {
            Console.WriteLine($"'{item.Title}' повернена.");
            item.SetState(new AvailableState());
        }
        public void Reserve(LibraryItem item) => Console.WriteLine($"'{item.Title}' не можна зарезервувати, поки видана.");
    }
}
