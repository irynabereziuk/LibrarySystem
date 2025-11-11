using System;
using System.Text;


namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var service = new LibraryService();

            var user1 = new User("Ірина");
            var user2 = new User("Олександр");

            var book = new Book("Місто", "Валер'ян Підмогильний");
            var journal = new Journal("Пізнайко", 5);

            book.DisplayInfo();
            journal.DisplayInfo();
            Console.WriteLine();

            // 1. Ірина бере книгу
            service.LendItem(book, user1);

            // 2. Олександр пробує взяти ту ж книгу — виняток
            service.LendItem(book, user2);

            // 3. Книга повертається
            book.ReturnItem();
            Console.WriteLine($"'{book.Title}' повернута до бібліотеки.\n");

            // 4. Тепер Олександр бере книгу
            service.LendItem(book, user2);

            // 5. Видача журналу
            service.LendItem(journal, user1);

            Console.WriteLine("Роботу сервісу завершено.");
        }
    }
}