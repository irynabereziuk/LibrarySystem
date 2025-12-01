using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface ILibraryService
    {
        void LendBook(string title);
        void ReturnBook(string title);
        void AddNewBook(string title, string author);
    }
}
