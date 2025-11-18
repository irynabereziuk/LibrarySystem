using System;

namespace LibrarySystem
{
    internal class RareBook : LibraryItem
    {
        public string CuratorNote { get; private set; }

        public RareBook(string title, string curatorNote = null) : base(title)
        {
            CuratorNote = curatorNote;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Рідкісна книга: {Title}{(string.IsNullOrEmpty(CuratorNote) ? "" : $", Примітка: {CuratorNote}")}");
        }
    }
}
