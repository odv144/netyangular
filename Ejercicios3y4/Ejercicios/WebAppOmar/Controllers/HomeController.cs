using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppOmar.Models;

namespace WebAppOmar.Controllers
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
            int id = 0;
            //agregando 2 lineas
            return View();
            //varios cambios nuevos
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Casa()
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