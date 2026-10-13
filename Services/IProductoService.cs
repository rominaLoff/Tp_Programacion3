using Tp_Programacion3.Models; //así conoce la clase Producto que está en Models
namespace Tp_Programacion3.Services
{
    //Dice qué puede hacer el servicio pero no cómo lo hace. La implementación concreta se encuentra en la clase ProductoService.
    public interface IProductoService
    {
        List<Producto> ObtenerTodos(); //Trae todos los productos
        Producto? ObtenerPorId(int id); //Trae un producto por su id
    }
}
