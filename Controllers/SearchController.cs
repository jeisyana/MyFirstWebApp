using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(string departure, string arrival, DateTime travelDate, int passengers)
        {
            ViewBag.Departure = departure;
            ViewBag.Arrival = arrival;
            ViewBag.TravelDate = travelDate.ToShortDateString();
            ViewBag.Passengers = passengers;

            return View();
        }
    }
}
