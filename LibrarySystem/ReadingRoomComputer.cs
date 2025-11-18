using System;

namespace LibrarySystem
{
    internal class ReadingRoomComputer : LibraryItem
    {
        public string Location { get; private set; }

        public ReadingRoomComputer(string id, string location = "Читальна зала") : base(id)
        {
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Комп'ютер у читальній залі: {Title}, Розташування: {Location} (не видається додому)");
        }
    }
}