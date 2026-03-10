using ferroERP.api.Models;
using ferroERP.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ferroERP.api.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly InventarioService inventario = new InventarioService();

        [HttpGet]
        public IActionResult ListarProductos()
        {
            return Ok(inventario.ObtenerProductos());
        }

        [HttpPost]
        public IActionResult RegistrarProducto([FromBody] Producto producto)
        {
            var nuevo = inventario.RegistrarProducto(producto);
            return Ok(nuevo);
        }

        [HttpPost("entrada")]
        public IActionResult EntradaStock(int id, int cantidad)
        {
            var resultado = inventario.EntradaStock(id, cantidad);

            if (!resultado)
                return BadRequest("Producto no encontrado");

            return Ok("Stock actualizado");
        }

        [HttpPost("salida")]
        public IActionResult SalidaStock(int id, int cantidad)
        {
            var resultado = inventario.SalidaStock(id, cantidad);

            if (!resultado)
                return BadRequest("Stock insuficiente");

            return Ok("Stock descontado");
        }
    }
}