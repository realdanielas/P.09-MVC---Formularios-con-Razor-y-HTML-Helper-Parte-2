namespace P._09_MVC___Formularios_con_Razor_y_HTML_Helper_Parte_2.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
