using Microsoft.AspNetCore.Mvc;
using P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models;
using System.Diagnostics;

namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
