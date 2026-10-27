using Microsoft.Data.SqlClient;
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
            var productos = new List<Producto>();

            //se abre la conexión a la base de datos utilizando la connection string.
            using SqlConnection conexion =new SqlConnection (_connectionString);
            conexion.Open();

            //Se prepara la consulta
            string sql = "SELECT Id, Nombre, Precio, Stock FROM Productos";
            using SqlCommand commando = new SqlCommand(sql, conexion);

            //se ejecuta y se leen los resultados fila por fila, creando objetos Producto y agregándolos a la lista.
            using SqlDataReader lector = commando.ExecuteReader();
            
                while (lector.Read())
                {
                Producto producto = new Producto
                {
                    Id = lector.GetInt32(0),  //columna 0: Id
                    Nombre = lector.GetString(1),//columna 1: Nombre
                    Precio = lector.GetDecimal(2),//columna 2: Precio
                    Stock = lector.GetInt32(3) //columna 3: Stock
                };
                    productos.Add(producto);
                }
            return productos;
            //throw new NotImplementedException();
        }

        // trae el producto por su id, si no lo encuentra devuelve null
        public Producto? ObtenerPorId(int id) // Implementación del método para obtener un producto por su ID desde la base de datos.
        {
            using SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();

            //el @Id es un parámetro de la consulta SQL para evitar inyecciones SQL.(no concatenar directamente el id con el texto en la consulta)
            string sql = "SELECT Id, Nombre, Precio, Stock FROM Productos WHERE Id = @Id";
            using SqlCommand commando = new SqlCommand( sql, conexion);
            commando.Parameters.AddWithValue("@Id", id);

            using SqlDataReader lector = commando.ExecuteReader();
            if (lector.Read())
            {
                return new Producto
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Precio = lector.GetDecimal(2),
                    Stock = lector.GetInt32(3)
                };
                
                
            }
            return null; // Si no se encuentra el producto, devuelve null.
            
           
            //throw new NotImplementedException();
        }
    }
}
