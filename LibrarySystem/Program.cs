using System;
using System.Text;
using System.Collections.Generic;

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

            // Оригінальні об'єкти
            var book = new Book("Місто", "Валер'ян Підмогильний");
            var journal = new Journal("Пізнайко", 5);

            // Нові (за умовою)
            var rare = new RareBook("Кобзар (першодрук)", "Обережно: тільки в читальній залі");
            var computer = new ReadingRoomComputer("ПК №12", "Читальна зала - ряд 2");

            // Демонстрація DisplayInfo() через базовий тип (LSP)
            List<LibraryItem> items = new List<LibraryItem> { book, journal, rare, computer };
            Console.WriteLine("Список предметів у бібліотеці:");
            foreach (var it in items)
            {
                it.DisplayInfo();
            }
            Console.WriteLine();

            // Видача: показати нормальну видачу і помилки
            service.LendItem(book, user1);   // має працювати
            service.LendItem(book, user2);   // зайнята - помилка

            book.ReturnItem();
            Console.WriteLine($"'{book.Title}' повернута до бібліотеки.\n");

            service.LendItem(book, user2);   // тепер працює

            service.LendItem(journal, user1); // журнал можна видати

            // Спроби видати те, що не можна
            service.LendItem(rare, user1);      // має вивести помилку (не можна видати)
            service.LendItem(computer, user1);  // теж помилка

            // ---- Штрафи (Strategy) ----
            var fineService = new FineService(new StandardFine(5m));
            Console.WriteLine("\n--- Розрахунок штрафів: StandardFine ---");
            fineService.ShowFine(book, 5);      // можна — книга береться додому
            fineService.ShowFine(journal, 3);   // можна — журнал

            Console.WriteLine("\n--- Розрахунок штрафів: ProgressiveFine ---");
            fineService.SetStrategy(new ProgressiveFine(3m, 2m));
            fineService.ShowFine(book, 5);      // різний результат

            // Спроба розрахувати штраф для об'єкта, якого не видають додому
            Console.WriteLine("\n--- Спроба розрахувати штраф для рідкісної книги та комп'ютера ---");
            fineService.ShowFine(rare, 4);      // має показати помилку StrategyNotApplicableException
            fineService.ShowFine(computer, 2);  // також помилка

            Console.WriteLine("\nРоботу сервісу завершено.");
        }
    }
}