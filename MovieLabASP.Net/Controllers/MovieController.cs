﻿using Microsoft.AspNetCore.Mvc;
using MovieLabASP.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLabASP.Net.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View("MovieForm");
        }

        public IActionResult MovieForm(Movie movie)
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
