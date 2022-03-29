using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
