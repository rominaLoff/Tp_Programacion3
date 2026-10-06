using Microsoft.AspNetCore.Mvc;

namespace Tp_Programacion3.Controllers
{
    [ApiController] // Marca la clase como un controlador de API
    [Route("api/[controller]")] // Ruta Base: api/productos . Define la ruta base para las acciones del controlador, [controller] se reemplaza por el nombre del controlador sin el sufijo "Controller"
    public class ProductosController : ControllerBase
    {
        // GET: api/productos
        [HttpGet]
        public string GetTodos()
        {
            return "El controlador de productos funciona";
        }
    }
}
