using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace MovieLabASP.Net.Models
{
    public class Movie: IEnumerable<Movie>
    {
        public int ID { get; set; }

        [Required(ErrorMessage="You must give me a proper title")]
        [StringLength(45, ErrorMessage ="The title is too long")]
        public string Title { get; set; }
        public  Genre Genre { get; set; }
        [Range(1180, 2020, ErrorMessage="This year is invalid")]
        public int Year { get; set; }
        [StringLength(25, ErrorMessage ="Please enter a real actor")]
        public string Actors { get; set; }
        [StringLength(25, ErrorMessage = "Please enter a real director")]
        public string Directors { get; set; }
        

        public Movie(int id, string title, Genre Genre, int year, string actors, string directors)
        {
            this.ID = id;
            this.Title = title;
            this.Genre = Genre;
            this.Year = year;
            this.Actors = actors;
            this.Directors = directors;

        }

        public Movie() { }

      

        // List<Movie> Movies = new List<Movie>();
        public void PrintMovie()
        {
            Console.WriteLine($"{ID}, {Title}, {Genre}, {Year}, {Actors}, {Directors}");

        }
        public void AddID()
        {
          
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
