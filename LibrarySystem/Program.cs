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

            // Factory method: створюємо фабрики
            ILibraryItemFactory bookFactory = new BookFactory();
            ILibraryItemFactory journalFactory = new JournalFactory();
            ILibraryItemFactory audioFactory = new AudioCDFactory();

            // Використовуємо фабрики для створення об'єктів
            var book = bookFactory.Create("Місто", "Валер'ян Підмогильний");
            var journal = journalFactory.Create("Пізнайко", 5);
            var cd = audioFactory.Create("Класика польська", "Various Artists", 60);

            // Об’єкти, які не можна брати додому
            var rare = new RareBook("Кобзар (першодрук)", "Обережно: тільки в читальній залі");
            var computer = new ReadingRoomComputer("ПК №12", "Читальна зала - ряд 2");

            // Демонстрація DisplayInfo
            List<LibraryItem> items = new List<LibraryItem> { book, journal, cd, rare, computer };
            Console.WriteLine("=== Список предметів у бібліотеці ===");
            foreach (var it in items)
            {
                it.DisplayInfo();
            }
            Console.WriteLine();

            // Демонстрація видачі через LibraryService
            var user1 = new User("Ірина");
            var user2 = new User("Олександр");

            service.LendItem(book, user1);
            service.LendItem(book, user2); // зайнята — помилка

            book.ReturnItem();
            Console.WriteLine($"'{book.Title}' повернута до бібліотеки.\n");

            service.LendItem(book, user2);
            service.LendItem(journal, user1);
            service.LendItem(rare, user1);      // помилка — не можна видати
            service.LendItem(computer, user1);  // помилка — не можна видати

            // ---- Штрафи (Strategy) ----
            var fineService = new FineService(new StandardFine(5m));
            Console.WriteLine("\n--- Розрахунок штрафів: StandardFine ---");
            fineService.ShowFine(book, 5);
            fineService.ShowFine(journal, 3);

            fineService.SetStrategy(new ProgressiveFine(3m, 2m));
            Console.WriteLine("\n--- Розрахунок штрафів: ProgressiveFine ---");
            fineService.ShowFine(book, 5);

            Console.WriteLine("\n--- Спроба розрахувати штраф для рідкісної книги та комп'ютера ---");
            fineService.ShowFine(rare, 4);
            fineService.ShowFine(computer, 2);

            // ---------------- Builder ----------------
            var centralFactory = new CentralLibraryFactory();
            var cardForIryna = centralFactory.CreateReaderCard();

            var builder = new ReaderProfileBuilder()
                .SetName("Ірина")
                .SetAddress("Київ, вул. Л. Українки, 10")
                .AddSubscription("Пізнайко")
                .SetReaderCard(cardForIryna);

            var profile = builder.Build();

            Console.WriteLine("\n=== Reader Profile (Builder) ===");
            profile.Display();
            Console.WriteLine();

            // ---------------- Abstract Factory ----------------
            Console.WriteLine("=== Abstract Factory demo: Central vs Scientific ===\n");

            RunConfigurator(new CentralLibraryFactory(), "Central Library");
            RunConfigurator(new ScientificLibraryFactory(), "Scientific Library");

            Console.WriteLine("\nРоботу сервісу завершено.");
        }

        // Метод конфігуратора для Abstract Factory
        static void RunConfigurator(ILibraryBranchFactory factory, string title)
        {
            Console.WriteLine($"--- Конфігурація для: {title} ---");

            var item = factory.CreateLibraryItem("book", "Основи фізики", "Іванов");
            var card = factory.CreateReaderCard();
            var policy = factory.
                CreateLoanPolicy();

            Console.WriteLine("Створено предмет:");
            item?.DisplayInfo();
            Console.WriteLine("Створено картку читача: " + card.GetInfo());
            Console.WriteLine("Політика позики: " + policy.GetPolicyInfo());

            var profile = new ReaderProfileBuilder()
                .SetName("Олександр (з " + title + ")")
                .SetAddress("Адреса тестова")
                .SetReaderCard(card)
                .Build();

            profile.Display();

            Console.WriteLine($"Можна взяти додому? {policy.CanBeTakenHome}");
            Console.WriteLine();
        }
    }
}