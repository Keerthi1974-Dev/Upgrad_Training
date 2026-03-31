using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("Feedback")]
    public class FeedbackController : Controller
    {
        
        [HttpGet("Form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("Form")]
        public IActionResult Form(Feedback f)
        {
            if (f.Rating >= 4)
            {
                ViewData["Message"] = "Thank You!!";
            }
            else
            {
                ViewData["Message"] = "We will improve";
            }

            return View();
        }
    }
}