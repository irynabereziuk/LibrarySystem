using System.Collections.Generic;

namespace LibrarySystem
{
    internal class ReaderProfile
    {
        public string Name { get; internal set; }
        public string Address { get; internal set; }
        public List<string> Subscriptions { get; } = new List<string>();
        public IReaderCard Card { get; internal set; }

        public void Display()
        {
            System.Console.WriteLine($"Читач: {Name}");
            System.Console.WriteLine($"Адреса: {Address}");
            System.Console.WriteLine($"Підписки: {(Subscriptions.Count == 0 ? "нема" : string.Join(", ", Subscriptions))}");
            System.Console.WriteLine($"Картка: {(Card == null ? "нема" : Card.GetInfo())}");
        }
    }
}