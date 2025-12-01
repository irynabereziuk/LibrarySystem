using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ScientificLibraryFactory : ILibraryBranchFactory
    {
        public LibraryItem CreateLibraryItem(string itemType, string title, params object[] args)
        {
            switch (itemType?.ToLower())
            {
                case "book":
                    var author = args != null && args.Length > 0 && args[0] is string ? (string)args[0] : "Unknown";
                    return new Book(title, author);
                case "journal":
                    var issue = args != null && args.Length > 0 && args[0] is int ? (int)args[0] : 1;
                    return new Journal(title, issue); // можна поміняти на ScientificJournal
                case "audiocd":
                    var artist = args != null && args.Length > 0 && args[0] is string ? (string)args[0] : "Unknown";
                    var dur = args != null && args.Length > 1 && args[1] is int ? (int)args[1] : 0;
                    return new AudioCD(title, artist, dur);
                default:
                    return null;
            }
        }

        public IReaderCard CreateReaderCard()
        {
            return new ScholarReaderCard();
        }

        public ILoanPolicy CreateLoanPolicy()
        {
            return new ReadingRoomOnlyPolicy();
        }
    }
}