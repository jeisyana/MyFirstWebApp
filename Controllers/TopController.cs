using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class TopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
