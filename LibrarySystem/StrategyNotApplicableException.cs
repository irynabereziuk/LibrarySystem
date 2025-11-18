using System;

namespace LibrarySystem
{
    internal class StrategyNotApplicableException : Exception
    {
        public StrategyNotApplicableException(string message) : base(message) { }
    }
}