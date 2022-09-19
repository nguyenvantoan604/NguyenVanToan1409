using Microsoft.AspNetCore.Mvc;
using NguyenVanToan_0709.Models;
using System.Diagnostics;

namespace NguyenVanToan_0709.Controllers
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
            return View();
        }
   

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int StudentID, string FullName, int Age)
        {
                ViewBag.student = "ID: " + StudentID    + "-  " + "Name: " + FullName + "-   " +"Age:"+ Age;
            return View();
        }
  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}