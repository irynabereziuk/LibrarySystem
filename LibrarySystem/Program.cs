using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;

                var pLend = new Permission("LEND_BOOK");
            var pReturn = new Permission("RETURN_BOOK");
            var pAdd = new Permission("ADD_NEW_BOOK");

            var readerRole = new Role("Reader", new List<Permission> { pLend, pReturn });
            var librarianRole = new Role("Librarian", new List<Permission> { pLend, pReturn });
            var adminRole = new Role("Administrator", new List<Permission> { pAdd });

            var userReader = new UserRBAC("Катя", new List<Role> { readerRole });
            var userLibrarian = new UserRBAC("Марія", new List<Role> { librarianRole });
            var userAdmin = new UserRBAC("Антон", new List<Role> { adminRole });

            var originalService = new LibraryServiceRBAC(); // тепер реалізує ILibraryService
            var authService = new AuthorizationService();

            Console.WriteLine("\n=== Reader Tests ===");
            var readerSecure = new SecureLibraryServiceDecorator(originalService, authService, userReader);

            readerSecure.LendBook("Гаррі Поттер");
            readerSecure.ReturnBook("Гаррі Поттер");
            Try(() => readerSecure.AddNewBook("1984", "Оруелл"));

            Console.WriteLine("\n=== Librarian Tests ===");
            var librarianSecure = new SecureLibraryServiceDecorator(originalService, authService, userLibrarian);

            librarianSecure.LendBook("Місто");
            librarianSecure.ReturnBook("Місто");
            Try(() => librarianSecure.AddNewBook("Фраза", "Автор"));

            Console.WriteLine("\n=== Admin Tests ===");
            var adminSecure = new SecureLibraryServiceDecorator(originalService, authService, userAdmin);

            adminSecure.AddNewBook("Чорний Ворон", "Шкляр");
            Try(() => adminSecure.LendBook("Чорний Ворон"));
            Try(() => adminSecure.ReturnBook("Чорний Ворон"));
        }

        static void Try(Action action)
        {
            try { action(); }
            catch (Exception ex) { Console.WriteLine($"[Помилка] {ex.Message}"); }
        }
    }
}