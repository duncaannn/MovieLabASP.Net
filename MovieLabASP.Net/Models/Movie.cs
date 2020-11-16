using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabASP.Net.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public  Genre Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

        public Movie(int id, string title, string genre, int year, string actors, string directors)
        {
            ID = id;
            Title = title;
            Genre = Genre;
            Year = year;
            Actors = actors;
            Directors = directors;

        }

        public Movie() { }

        public void PrintMovie()
        {
            
        }
        public void AddID()
        {
          
        }
    }
}
