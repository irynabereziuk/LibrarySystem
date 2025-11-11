using System;

namespace LibrarySystem
{
    internal abstract class LibraryItem
    {
        public string Title { get; private set; }
        public bool IsLent { get; private set; }

        protected LibraryItem(string title)
        {
            Title = title;
            IsLent = false;
        }

        public void Lend()
        {
            IsLent = true;
        }

        public void ReturnItem()
        {
            IsLent = false;
        }

        public abstract void DisplayInfo();
    }
}