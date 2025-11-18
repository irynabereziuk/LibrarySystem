using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class StandardFine : IFineCalculationStrategy
    {
        private readonly decimal _perDay;

        public StandardFine(decimal perDay = 5m)
        {
            _perDay = perDay;
        }

        public decimal CalculateFine(int overdueDays)
        {
            if (overdueDays <= 0) return 0m;
            return overdueDays * _perDay;
        }
    }
}