using Microsoft.AspNetCore.Mvc;
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
}
