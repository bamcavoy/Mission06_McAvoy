using Microsoft.AspNetCore.Mvc;
using Mission06mvc.Models;
using System.Diagnostics;

namespace Mission06mvc.Controllers
{
    public class HomeController : Controller
    {
        private MovieListContext _context;
        public HomeController(MovieListContext movieListContext) // Constructor
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

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Movie());
        }

        //what to do when movie is added to list
        [HttpPost]
        public IActionResult Form(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                //add to db
                _context.Movies.Add(newMovie);
                _context.SaveChanges();

                //show confirmation window and pass movie details
                return View("Confirmation", newMovie);
            }
            else // invalid data
            {
                ViewBag.categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(newMovie);
            }

        }

        public IActionResult Collection()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            ViewBag.categories = _context.Categories.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var movieToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Form", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie) 
        { 
            if (ModelState.IsValid)
            {
                _context.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("Collection");
            }
            else
            {
                return View("Form", movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var movieToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }
    }
}
