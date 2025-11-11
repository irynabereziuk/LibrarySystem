using System;

namespace LibrarySystem
{
    internal class Journal : LibraryItem
    {
        public int IssueNumber { get; private set; }

        public Journal(string title, int issueNumber)
            : base(title)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Журнал: {Title}, Випуск №{IssueNumber}");
        }
    }
}
