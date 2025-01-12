using Microsoft.AspNetCore.Mvc;

namespace CharitySosProje.Controllers
{
    public class Pages : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Donate()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult Page404()
        {
            return View();
        }
    }
}
