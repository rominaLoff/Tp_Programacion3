using Tp_Programacion3.Models;
using Tp_Programacion3.Data;


namespace Tp_Programacion3.Services
{
    //Implementa el contrato de IProductoService con una lista fija. Aquí se define cómo se realizan las operaciones relacionadas con los productos.
    //public class ProductoService : IProductoService // se hereda de IProductoService, lo que significa que debe implementar todos los métodos definidos en esa interfaz.
    //{
    //    private List<Producto> _productos = new List<Producto>// Lista de productos que actúa como una base de datos simulada.
    //    {
    //        new Producto { Id = 1, Nombre = "Teclado", Precio = 150000, Stock = 10 },
    //        new Producto { Id = 2, Nombre = "Mouse", Precio = 8000, Stock = 25 },
    //        new Producto { Id = 3, Nombre = "Monitor", Precio = 90000, Stock = 5 },

    //    };

    //    public List<Producto> ObtenerTodos() // Implementación del método para obtener todos los productos.
    //    {
    //        return _productos; // Devuelve la lista completa de productos.
    //    }

    //    public Producto? ObtenerPorId(int id) // Implementación del método para obtener un producto por su ID.
    //    {
    //        foreach (Producto varTemP in _productos) // Itera a través de cada producto en la lista.
    //        {
    //            if (varTemP.Id == id) // Compara el ID del producto actual con el ID dado.
    //            {
    //                return varTemP; // Si encuentra una coincidencia, devuelve el producto.
    //            }
    //        }
    //        return null; // devuelve null si no se encuentra.
    //    }
    //}
    
    
    // El Service ya no tiene la lista en memoria: le pide los datos al Repository.
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        // ASP.NET nos inyecta el Repository por el constructor
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        // Le pide al Repository todos los productos
        public List<Producto> ObtenerTodos()
        {
            return _productoRepository.ObtenerTodos();
        }

        // Le pide al Repository un producto por su Id
        public Producto? ObtenerPorId(int id)
        {
            return _productoRepository.ObtenerPorId(id);
        }
    }


}
