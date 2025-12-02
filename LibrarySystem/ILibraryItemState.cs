using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface ILibraryItemState
    {
        void Lend(LibraryItem item);
        void Return(LibraryItem item);
        void Reserve(LibraryItem item);
    }
}