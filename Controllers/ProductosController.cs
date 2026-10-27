using Microsoft.AspNetCore.Mvc;
using Tp_Programacion3.Models;
using Tp_Programacion3.Services; // Importa el espacio de nombres donde se encuentra la interfaz IProductoService

namespace Tp_Programacion3.Controllers;

[ApiController] // Marca la clase como un controlador de API
[Route("api/[controller]")] // Ruta Base: api/productos . Define la ruta base para las acciones del controlador, [controller] se reemplaza por el nombre del controlador sin el sufijo "Controller"
public class ProductosController : ControllerBase
{
    private readonly IProductoService _productoService; // Declara una variable privada para almacenar la instancia del servicio de productos
   
    public ProductosController(IProductoService productoService)
    {
               _productoService = productoService; // Inyecta la dependencia del servicio de productos a través del constructor
    }
    
   
    // GET: api/productos
    [HttpGet]
    //public ActionResult GetProductos()
    //{
    //    return Ok("Respuesta 200 OK: el endpoint de productos funciona.");
    //}

    
    public IActionResult GetProductos()
    {
        var productos = _productoService.ObtenerTodos(); // Llama al método ObtenerTodos para obtener la lista de productos

       
        return Ok(productos); // Devuelve la lista de productos con un estado HTTP 200 OK
    }

    // GET/ api/productos/5
    [HttpGet("{id}")]
    public IActionResult GetProductoPorId(int id)
    {
        var producto = _productoService.ObtenerPorId(id); // Llama al método ObtenerPorId para obtener un producto específico por su ID

        if (producto == null)
        {
            return NotFound("No se encontraron productos."); // Devuelve un estado HTTP 404 Not Found si no hay productos
        }
        
        return Ok(producto); // Devuelve el producto encontrado con un estado HTTP 200 OK
    }
    
}
