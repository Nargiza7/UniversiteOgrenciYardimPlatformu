using Microsoft.AspNetCore.Mvc;

namespace CharitySosProje.Controllers
{
    public class Enterprice : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult HumanResources()
        {
            return View();
        }
        public IActionResult OurValues()
        {
            return View();
        }
    }
}
