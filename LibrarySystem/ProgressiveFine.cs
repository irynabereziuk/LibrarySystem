using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ProgressiveFine : IFineCalculationStrategy
    {
        // приклад: перший день 3, другий 5, третій 7,... (зростає на step)
        private readonly decimal _initial;
        private readonly decimal _step;

        public ProgressiveFine(decimal initial = 3m, decimal step = 2m)
        {
            _initial = initial;
            _step = step;
        }

        public decimal CalculateFine(int overdueDays)
        {
            if (overdueDays <= 0) return 0m;
            decimal total = 0m;
            for (int day = 0; day < overdueDays; day++)
            {
                total += _initial + day * _step;
            }
            return total;
        }
    }
}