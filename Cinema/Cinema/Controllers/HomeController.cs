using Cinema.Models;
using Cinema.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(CinemaService.Sale);
        }
        [HttpPost]
        public IActionResult BookTicket(string firstName, string lastName, int salaId, bool isReduced)
        {
            var user = new User
            {
                Id = CinemaService.Tickets.Count + 1,
                FirstName = firstName,
                LastName = lastName
            };

            CinemaService.AddTicket(user, salaId, isReduced);

            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
