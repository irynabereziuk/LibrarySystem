using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface ILibraryItemFactory
    {
        LibraryItem Create(string title, params object[] args);
    }
}

