using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetMovies());
        }

        public IActionResult Details(int id)
        {
            var movie = _service.GetMovie(id);
            if (movie == null)
                return NotFound();

            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _service.AddMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            var movie = _service.GetMovie(id);
            if (movie == null)
                return NotFound();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            var movie = _service.GetMovie(id);
            if (movie == null)
                return NotFound();

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.DeleteMovie(id);
            return RedirectToAction("Index");
        }
    }
}