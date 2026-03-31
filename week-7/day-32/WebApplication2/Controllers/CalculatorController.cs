using Microsoft.AspNetCore.Mvc;

namespace newapp.Controllers
{
    [Route("Calculation")]
    public class CalculatorController : Controller
    {
        [HttpGet("Addition")]
        public IActionResult Sum()
        {
            return View();
        }

        [HttpPost("Addition")]
        public IActionResult Sum(int num1, int num2)
        {
            int result = num1 + num2;
            ViewBag.Result = result;

            return View();
        }
    }
}