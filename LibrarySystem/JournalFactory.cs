using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class JournalFactory : ILibraryItemFactory
    {
        // args[0] expected: issueNumber (int)
        public LibraryItem Create(string title, params object[] args)
        {
            var issue = args != null && args.Length > 0 && args[0] is int ? (int)args[0] : 1;
            return new Journal(title, issue);
        }
    }
}