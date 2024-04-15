using Microsoft.EntityFrameworkCore;
using P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models;

namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models
{
    public class equiposDbContext:DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Equipos> equipos { get; set; }
    }
}
