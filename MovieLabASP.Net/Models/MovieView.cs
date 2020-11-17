using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabASP.Net.Models
{
    public class MovieView :Movie
    {
        public List<Movie> Movies { get; set; }

       public MovieView() { }
        public MovieView(List<Movie> Movies)
        { this.Movies = Movies; }

        //List<Movie> Movies = new List<Movie>();
       




       

    }
}
