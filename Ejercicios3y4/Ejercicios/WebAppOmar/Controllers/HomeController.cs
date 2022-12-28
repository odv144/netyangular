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
            //Segundo intento el primero fallo
            return View();
            //varios cambios nuevos
            //tampoco se porque
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Taller()
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