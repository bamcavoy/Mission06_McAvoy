using Microsoft.AspNetCore.Mvc;
using Mission06mvc.Models;
using System.Diagnostics;

namespace Mission06mvc.Controllers
{
    public class HomeController : Controller
    {
        private MovieListContext _context;
        public HomeController(MovieListContext movieListContext)
        {
            _context = movieListContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        //what to do when movie is added to list
        [HttpPost]
        public IActionResult Form(Movie newMovie)
        {
            //add to db
            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            //show confirmation window and pass movie details
            return View("Confirmation", newMovie);
        }
    }
}
