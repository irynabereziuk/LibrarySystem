using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ItemUnavailableException:Exception
    {
        public ItemUnavailableException(string message) : base(message)
        {
        }
    }
}
