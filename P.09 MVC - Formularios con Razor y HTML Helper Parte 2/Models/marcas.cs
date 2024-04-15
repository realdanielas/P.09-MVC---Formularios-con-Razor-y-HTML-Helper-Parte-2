using System.ComponentModel.DataAnnotations;

namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models
{
    public class Marcas
    {
        [Key]

        [Display(Name ="ID")]
        public int id_marcas { get; set; }

        [Display(Name = "Nombre de la Marca")]
        public string? nombre_marcas { get; set; }

        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }

    public class Equipos
    {
        [Key]

        public int id_equipos { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public int tipo_equipo_id { get; set; }
        public int marca_id { get; set; }
        public string? modelo { get; set; }
        public int anio_compra { get; set; }
        public decimal costo { get; set; }
        public int vida_util { get; set; }
        public int estado_equipo_id { get; set; }
        public char estado { get; set; }
    }
}
