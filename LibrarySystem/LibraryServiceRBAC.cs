using System;

namespace LibrarySystem
{
    internal class LibraryServiceRBAC : ILibraryService
    {
        public void LendBook(string title)
        {
            Console.WriteLine($"Книга '{title}' видана читачу.");
        }

        public void ReturnBook(string title)
        {
            Console.WriteLine($"Книга '{title}' повернена до бібліотеки.");
        }

        public void AddNewBook(string title, string author)
        {
            Console.WriteLine($"Книга '{title}' ({author}) успішно додана до каталогу!");
        }
    }
}