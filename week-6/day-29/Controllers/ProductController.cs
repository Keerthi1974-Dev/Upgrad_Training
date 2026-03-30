using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Poco M7 Pro 5G", Price = 13999 },
            new Product { Id = 2, Name = "Acer Swift Neo Laptop", Price = 60990 },
            new Product { Id = 3, Name = "boAt Airdopes Earbuds", Price = 829 },
            new Product { Id = 4, Name = "Noise Smartwatch", Price = 1099 },
            new Product { Id = 5, Name = "boAt Bluetooth Speaker", Price = 4999 }
        };

        // INDEX
        public IActionResult Index()
        {
            return View(products);
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        // CREATE GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

         // CREATE POST
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                products.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // EDIT GET
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            var exist = products.FirstOrDefault(x => x.Id == obj.Id);
            if (exist != null)
            {
                exist.Name = obj.Name;
                exist.Price = obj.Price;
            }
            return RedirectToAction("Index");
        }

        // DELETE GET
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            if (p != null) products.Remove(p);
            return RedirectToAction("Index");
        }
    }
}