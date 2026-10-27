using System.Data;
using Tp_Programacion3.Models;

namespace Tp_Programacion3.Data
{
    //Implementacion del Repository: define las operaciones que se pueden realizar sobre la entidad Producto;
    //las operaciones de acceso de datos. El código de acceso a datos se encuentra en esta clase, 
    //que implementa la interfaz IProductoRepository. El codigo SQL (ADO.NET)
    public class ProductoRepository : IProductoRepository

    {
        private readonly string _connectionString; //Guarda la connection string para conectarse a la base de datos que se lee desde appsettings.json

        public ProductoRepository(IConfiguration configuration) //Constructor que recibe la configuración de la aplicación. 
                                                                //Se utiliza para inicializar la connection string desde el archivo de configuración.
        {
            _connectionString = configuration.GetConnectionString("Programacion3")!;
        }

        public List<Producto> ObtenerTodos() // Implementación del método para obtener todos los productos desde la base de datos.
        {
            throw new NotImplementedException();
        }

        public Producto? ObtenerPorId(int id) // Implementación del método para obtener un producto por su ID desde la base de datos.
        {
            throw new NotImplementedException();
        }
    }
}
