using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie
{
    public class MovieDB
    {
            //Movies[] the_movies = {

            public List<Movies> movies = new List<Movies> {
                new Movies("A Hard Day's Night (1964)", Rating.G, Genre.MUSICALS),
                new Movies("All Quiet on the Western Front (1930)", Rating.NR, Genre.WAR),
                new Movies("Argo (2012)", Rating.R, Genre.WAR),
                new Movies("Baby Driver (2017)", Rating.R, Genre.ACTION),
                new Movies("Black Panther (2018)", Rating.PG13, Genre.SCIFI),
                new Movies("Captain America: Civil War (2016)", Rating.PG13, Genre.SCIFI),
                new Movies("Casablanca (1942)", Rating.PG, Genre.ROMANCE),
                new Movies("Coco (2017)", Rating.PG, Genre.CHILDCARTOON),
                new Movies("Dr. Strangelove Or How I Learned to Stop Worrying and Love the Bomb (1964)", Rating.PG, Genre.WAR),
                new Movies("Dunkirk (2017)", Rating.R, Genre.WAR),
                new Movies("E.T. The Extra-Terrestrial (1982)", Rating.PG, Genre.SCIFI),
                new Movies("Finding Dory (2016)", Rating.G, Genre.CHILDCARTOON),
                new Movies("Inside Out (2015)", Rating.PG, Genre.CHILDCARTOON),
                new Movies("King Kong (1933)", Rating.NR, Genre.ACTION),
                new Movies("Logan (2017)", Rating.R, Genre.ACTION),
                new Movies("Mad Max: Fury Road (2015)", Rating.R, Genre.ACTION),
                new Movies("Metropolis (1927)", Rating.NR, Genre.SCIFI),
                new Movies("North by Northwest (1959)", Rating.PG, Genre.ACTION),
                new Movies("Pinocchio (1940)", Rating.G, Genre.CHILDCARTOON),
                new Movies("Psycho (1960)", Rating.R, Genre.HORROR),
                new Movies("Rosemary's Baby (1968)", Rating.R, Genre.HORROR),
                new Movies("Seven Samurai (Shichinin no Samurai) (1956)", Rating.NR, Genre.ACTION),
                new Movies("Singin' in the Rain (1952)", Rating.G, Genre.MUSICALS),
                new Movies("Snow White and the Seven Dwarfs (1937)", Rating.G, Genre.CHILDCARTOON),
                new Movies("Spider-Man: Homecoming (2017)", Rating.PG13, Genre.SCIFI),
                new Movies("Star Wars: Episode VII - The Force Awakens (2015)", Rating.PG13, Genre.SCIFI),
                new Movies("Star Wars: The Last Jedi (2017)", Rating.PG13, Genre.SCIFI),
                new Movies("Steve Jobs (2015)", Rating.PG13, Genre.DRAMA),
                new Movies("The Dark Knight (2008)", Rating.PG13, Genre.SCIFI),
                new Movies("The Godfather (1972)", Rating.R, Genre.DRAMA),
                new Movies("The Maltese Falcon (1941)", Rating.NR, Genre.DRAMA),
                new Movies("The Shawshank Redemption (1994)", Rating.PG13, Genre.DRAMA),
                new Movies("The Third Man (1949)", Rating.NR, Genre.DRAMA),
                new Movies("The Wizard of Oz (1939)", Rating.PG, Genre.EPICS),
                new Movies("Thor: Ragnarok (2017)", Rating.PG13, Genre.ACTION),
                new Movies("Wonder Woman (2017)", Rating.PG13, Genre.ACTION)
           };

        //List<Movies> movies = new List<Movies>(the_movies).ToList();

        public List<Movies> GetAllMovies()
        {
            return movies.ToList();
        }

        public List<Movies> GetAllMoviesByRating(Rating r)
        {
            return movies.Where(m => m.Rating == r).ToList();
        }

        public List<Movies> GetAllMoviesByGenre(Genre g)
        {
            return movies.Where(m => m.Genre == g).ToList();
        }

        public string DeleteMovieByIndex(int i)
        {
            var message = "";
            try
            {
                movies.Remove(movies[i]);
                message = "Movie has been removed";
            }
            catch (Exception)
            {
                message = "This Movie does not exist";
            }
            return message;
        }
    }
}