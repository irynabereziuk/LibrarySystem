using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface ILoanPolicy
    {
        int LoanDays { get; }
        bool CanBeTakenHome { get; }
        string GetPolicyInfo();
    }
}