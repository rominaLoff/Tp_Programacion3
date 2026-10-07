using Microsoft.AspNetCore.Mvc;

namespace Tp_Programacion3.Controllers
{
    [ApiController] // Marca la clase como un controlador de API
    [Route("api/[controller]")] // Ruta Base: api/productos . Define la ruta base para las acciones del controlador, [controller] se reemplaza por el nombre del controlador sin el sufijo "Controller"
    public class ProductosController : ControllerBase
    {
        // GET: api/productos
        [HttpGet]
        public ActionResult GetProductos()
        {
            return Ok("Respuesta 200 OK: el endpoint de productos funciona.");
        }
    }
}
