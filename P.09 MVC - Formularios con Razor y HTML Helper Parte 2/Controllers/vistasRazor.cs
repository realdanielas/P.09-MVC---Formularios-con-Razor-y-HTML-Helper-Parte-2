using Microsoft.AspNetCore.Mvc;
using P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models;
using Microsoft.EntityFrameworkCore;

namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Controllers
{
    public class vistasRazor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
