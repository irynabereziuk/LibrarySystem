using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class StandardReaderCard : IReaderCard
    {
        public string GetInfo() => "Standard Reader Card (звичайна картка)";
    }
}