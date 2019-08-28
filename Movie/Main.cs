using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Main
    {
        public static void main(String[] args)
        {
            MovieDB movieDB = new MovieDB();
            ConsoleUI con = ConsoleUI.getUI();
            bool moreTasks = true;
            do
            {
                Choices choice = con.GetChoice();
                switch (choice)
                {
                    case Choices.LIST: con.OutputMovies(movieDB.GetAllMovies()); break;
                    case Choices.BYRATING: con.OutputMovies(movieDB.GetAllMoviesByRating(con.GetRating())); break;
                    case Choices.BYGENRE: con.OutputMovies(movieDB.GetAllMoviesByGenre(con.GetGenre())); break;
                    case Choices.DELETE:
                        Console.WriteLine(movieDB.DeleteMovieByIndex(con.GetMovieToDelete(movieDB.movies))); break;
                   case Choices.EXIT: moreTasks = false; break;
                   default: Console.WriteLine("error"); break;
                }
            } while (moreTasks);
        }
    }
}
