using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class AudioCDFactory : ILibraryItemFactory
    {
        // args[0]: artist (string), args[1]: duration (int)
        public LibraryItem Create(string title, params object[] args)
        {
            var artist = args != null && args.Length > 0 && args[0] is string ? (string)args[0] : "Unknown Artist";
            var dur = args != null && args.Length > 1 && args[1] is int ? (int)args[1] : 0;
            return new AudioCD(title, artist, dur);
        }
    }
}