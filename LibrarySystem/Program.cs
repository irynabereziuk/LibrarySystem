using System;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- Спостерігач ---");
            var book = new Book("1984", "Джордж Орвелл");
            var reservationService = new ReservationService();
            var readerNotifier = new ReaderNotifier();

            book.Attach(reservationService);
            book.Attach(readerNotifier);

            book.DisplayInfo();
            book.ReturnBook();
            book.ReserveBook();

            Console.WriteLine("\n--- Шаблонний метод ---");
            NewBookAcquisition physical = new PhysicalBookAcquisition();
            NewBookAcquisition ebook = new EBookAcquisition();

            physical.RunAcquisition();
            ebook.RunAcquisition();

            Console.WriteLine("\n--- Стан ---");
            book.Lend();       
            book.Lend();       
            book.ReturnItem();  
            book.Reserve();    
            book.Lend();        
        }
    }
}