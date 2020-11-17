using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieLabASP.Net.Models;

namespace MovieLabASP.Net.Controllers
{
    public class DisplayMovie2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayMovie2()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult DisplayMovie2(Movie movie)
        {
           int id = movie.ID;
            string title = movie.Title;
            Genre genre = movie.Genre;
            int year = movie.Year;
            string actors = movie.Actors;
            string directors = movie.Directors;

           
            
            
            return View();
        }

     
    }
}
