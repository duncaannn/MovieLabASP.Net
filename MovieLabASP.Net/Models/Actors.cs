using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabASP.Net.Models
{
    public class Actors:Movie
    {
        public List<string> ActorsList { get; set; }

        public string WriteActors()
        {
            string Actors = $"{ActorsList}";
            return Actors;
        }

        public Actors()
        {

        }
    }
}
