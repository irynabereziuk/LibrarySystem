using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ReadingRoomOnlyPolicy : ILoanPolicy
    {
        public int LoanDays => 0;
        public bool CanBeTakenHome => false;
        public string GetPolicyInfo() => "Reading-room only (не видається додому)";
    }
}