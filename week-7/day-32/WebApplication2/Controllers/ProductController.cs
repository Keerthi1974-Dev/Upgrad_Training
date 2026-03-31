using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();

        [HttpGet("Add")]
        public IActionResult Add()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost("Add")]
        public IActionResult Add(Product p)
        {
            products.Add(p);
            ViewBag.Products = products;
            return View();
        }
    }
}