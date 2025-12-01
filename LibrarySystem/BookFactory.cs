using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class BookFactory : ILibraryItemFactory
    {
        // args[0] expected: author (string)
        public LibraryItem Create(string title, params object[] args)
        {
            var author = args != null && args.Length > 0 && args[0] is string ? (string)args[0] : "Unknown";
            return new Book(title, author);
        }
    }
}