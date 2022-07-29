using Microsoft.AspNetCore.Mvc;
using SimpleWebAPP.Models;
using System.Diagnostics;

namespace SimpleWebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // https://localhost:5555/home/Index
        // Controller (home controller -> view (home/Index)
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:5555/home/Privacy
        // Controller (home controller -> view (home/Privacy)
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