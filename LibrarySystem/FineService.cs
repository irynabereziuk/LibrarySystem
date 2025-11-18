using System;

namespace LibrarySystem
{
    internal class FineService
    {
        private IFineCalculationStrategy _strategy;

        public FineService(IFineCalculationStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void SetStrategy(IFineCalculationStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        // Повертає штраф або викидає StrategyNotApplicableException, якщо стратегію не можна застосувати
        public decimal CalculateFine(LibraryItem item, int overdueDays)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (overdueDays <= 0) return 0m;

            // Перевірка сумісності: штраф застосовується тільки до тих, кого можна брати додому
            if (item is not ICanBeTakenHome)
                throw new StrategyNotApplicableException($"До предмета '{item.Title}' не можна застосувати розрахунок штрафу (не можна брати додому).");

            return _strategy.CalculateFine(overdueDays);
        }

        // Метод для зручного виводу і обробки винятків
        public void ShowFine(LibraryItem item, int overdueDays)
        {
            try
            {
                var fine = CalculateFine(item, overdueDays);
                Console.WriteLine($"Штраф для '{item.Title}' за {overdueDays} дн. прострочки = {fine} грн.");
            }
            catch (StrategyNotApplicableException ex)
            {
                Console.WriteLine($"Помилка при розрахунку штрафу: {ex.Message}");
            }
        }
    }
}