using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ScholarReaderCard : IReaderCard
    {
        public string GetInfo() => "Scholar Reader Card (наукова картка)";
    }
}