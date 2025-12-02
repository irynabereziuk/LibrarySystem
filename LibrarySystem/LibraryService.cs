using System;

namespace LibrarySystem
{
    internal class LibraryService
    {
        public void LendItem(LibraryItem item, User user)
        {
            try
            {
                if (item == null || user == null)
                {
                    Console.WriteLine("Невірно вказано книгу або користувача.");
                    return;
                }

                
                if (item is not ICanBeTakenHome)
                    throw new ItemUnavailableException($"'{item.Title}' не можна видати додому.");

               
                item.Lend();

                Console.WriteLine($"{user.Name} успішно отримав(ла) '{item.Title}'.");
            }
            catch (ItemUnavailableException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Операція для '{item.Title}' завершена.\n");
            }
        }
    }
}