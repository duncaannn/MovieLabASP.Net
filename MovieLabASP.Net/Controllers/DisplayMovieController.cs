using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieLabASP.Net.Models;

namespace MovieLabASP.Net.Controllers
{
    public class DisplayMovieController : Controller
    {
        public IActionResult Index()
        {
            return View("DisplayMovie2");
        }

        public IActionResult DisplayMovie2(MovieView movieView)
        {

            return View("DisplayMovie2", movieView);
        }
    }
}
