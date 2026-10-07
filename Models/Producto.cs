namespace Tp_Programacion3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // se pone "string.Empty" para evitar nulls
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
