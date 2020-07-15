using System;

namespace Hyperbolic.Entities
{
    public class LevelInfoSmall
    {
        public string BackgroundURL { get; set; }

        public TimeSpan Length { get; set; }

        public string Title { get; set; }

        //TODO: Replace this with a class instead.
        public string Author { get; set; }

        //TODO: Replace this with a class instead.
        public string Song { get; set; }

        public int Ratings { get; set; }

        public int Downloads { get; set; }
    }
}