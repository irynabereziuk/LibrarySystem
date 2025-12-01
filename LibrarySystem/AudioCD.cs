using System;

namespace LibrarySystem
{
    internal class AudioCD : LibraryItem, ICanBeTakenHome
    {
        public string Artist { get; private set; }
        public int DurationMinutes { get; private set; }

        public AudioCD(string title, string artist, int durationMinutes = 0) : base(title)
        {
            Artist = artist;
            DurationMinutes = durationMinutes;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"AudioCD: {Title}, Artist: {Artist}, Duration: {DurationMinutes} хв.");
        }
    }
}