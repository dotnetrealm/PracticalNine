using Microsoft.AspNetCore.Mvc;

namespace PracticalNine.Controllers
{
    public class PracticalController : Controller
    {
        /// <summary>
        /// Test-01: To display string on web page
        /// </summary>
        /// <returns>ViewResult at ~/Views/Practical/Test1</returns>
        public IActionResult Test1()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

        /// <summary>
        /// Test-02: Lable Operation using Javascript
        /// </summary>
        /// <returns>ViewResult at ~/Views/Practical/Test2</returns>
        public IActionResult Test2()
        {
            return View();
        }

        /// <summary>
        /// Test-03: To display string on web page and assert result using Xunit
        /// </summary>
        /// <returns>ViewResult at ~/Views/Practical/Test3</returns>
        public IActionResult Test3()
        {
            ViewData["Message"] = "Hello World";
            return View();
        }
    }
}