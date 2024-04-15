using Microsoft.AspNetCore.Mvc;
using P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Controllers
{
    public class marcasController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public marcasController(equiposDbContext _equiposDbContexto)
        {
            _equiposDbContext = _equiposDbContexto;
        }

        public IActionResult Index()
        {
            var listaDeMarcas = (from m in _equiposDbContext.marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marcas");


            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marcas
                                    }).ToList();
            ViewData["listadoEquipo"] = listadoDeEquipos;

            return View();
        }

        public IActionResult CrearEquipos(Equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
