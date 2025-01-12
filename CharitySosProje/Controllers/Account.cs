using Microsoft.AspNetCore.Mvc;

namespace CharitySosProje.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

		public IActionResult Register()
		{
			return View();
		}

    }
}
