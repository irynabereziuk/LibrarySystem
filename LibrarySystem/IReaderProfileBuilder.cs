using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface IReaderProfileBuilder
    {
        IReaderProfileBuilder SetName(string name);
        IReaderProfileBuilder SetAddress(string address);
        IReaderProfileBuilder AddSubscription(string subscription);
        IReaderProfileBuilder SetReaderCard(IReaderCard card);
        ReaderProfile Build();
    }
}