using System;


namespace LibrarySystem
{
    internal class Book : LibraryItem
    {
        public string Author { get; private set; }

        public Book(string title, string author)
            : base(title)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}");
        }
    }
}