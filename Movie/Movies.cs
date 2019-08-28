using System;

namespace Movie
{
    public class Movies
    {
        public string Name { get; set; }
        public Rating Rating { get; set; }
        public Genre Genre { get; set; }

        public Movies(string name, Rating rating, Genre genre)
        {

        }
    }
}