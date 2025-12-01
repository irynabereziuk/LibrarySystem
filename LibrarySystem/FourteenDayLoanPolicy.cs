using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class FourteenDayLoanPolicy : ILoanPolicy
    {
        public int LoanDays => 14;
        public bool CanBeTakenHome => true;
        public string GetPolicyInfo() => $"14-day loan. Can be taken home: {CanBeTakenHome}";
    }
}