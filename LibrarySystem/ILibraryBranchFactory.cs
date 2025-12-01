using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
   
    internal interface ILibraryBranchFactory
    {
        LibraryItem CreateLibraryItem(string itemType, string title, params object[] args);
        IReaderCard CreateReaderCard();
        ILoanPolicy CreateLoanPolicy();
    }
}