using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class ReaderProfileBuilder : IReaderProfileBuilder
    {
        private readonly ReaderProfile _profile = new ReaderProfile();

        public IReaderProfileBuilder SetName(string name)
        {
            _profile.Name = name;
            return this;
        }

        public IReaderProfileBuilder SetAddress(string address)
        {
            _profile.Address = address;
            return this;
        }

        public IReaderProfileBuilder AddSubscription(string subscription)
        {
            if (!string.IsNullOrEmpty(subscription))
                _profile.Subscriptions.Add(subscription);
            return this;
        }

        public IReaderProfileBuilder SetReaderCard(IReaderCard card)
        {
            _profile.Card = card;
            return this;
        }

        public ReaderProfile Build()
        {
            // Тут можна додати перевірки (наприклад, Name не null)
            return _profile;
        }
    }
}