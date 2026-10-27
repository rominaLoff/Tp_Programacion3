using Tp_Programacion3.Models;

namespace Tp_Programacion3.Data
{
    //Contrato del Repository: define las opeaciones que se pueden realizar sobre la entidad Producto; las operaciones de acceso de datos.
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos(); // Trae todos los productos de la base de datos
        Producto? ObtenerPorId(int id); // Trae un producto por su id, si no existe devuelve null
    }
}
