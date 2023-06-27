using Microsoft.AspNetCore.Mvc;

namespace PracticalNine.Controllers
{
    public class PracticalController : Controller
    {
        public IActionResult Test1()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
        public IActionResult Test2()
        {
            return View();
        }
        public IActionResult Test3()
        {
            ViewData["Message"] = "Hello World";
            return View();
        }
    }
}