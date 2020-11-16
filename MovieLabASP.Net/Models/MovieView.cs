using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabASP.Net.Models
{
    public class MovieView :Movie
    {
        public List<Movie> Movies { get; set; }

        //MovieView movieInputs = new MovieView()
        //{
        //    Movies = new List<Movie>()
        
        //};

        public List<Movie> PrintMovies()
        {
            foreach(var movie in Movies)
            {
                Console.WriteLine(movie);
            }
            return Movies;
        }
    }
}
