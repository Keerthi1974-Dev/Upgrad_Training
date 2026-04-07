using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;
using WebApplication11.Repositories;

namespace WebApplication11.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: Details
        public IActionResult Details(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();

            return View(product);
        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // ✅ GET: Edit
        public IActionResult Edit(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();

            return View(product);
        }

        // ✅ POST: Edit
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // ✅ GET: Delete
        public IActionResult Delete(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();

            return View(product);
        }

        // ✅ POST: Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}