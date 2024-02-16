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

        [HttpPost]
        public IActionResult Form(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            return View("Confirmation", newMovie);
        }
    }
}
