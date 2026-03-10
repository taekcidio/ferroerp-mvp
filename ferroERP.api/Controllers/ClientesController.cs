using Microsoft.AspNetCore.Mvc;
using ferroERP.api.Models;
using ferroERP.api.Services;

namespace ferroERP.api.Controllers

{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService clienteService = new ClienteService();

        [HttpGet]
        public IActionResult ListarClientes()
        {
            return Ok(clienteService.ObtenerClientes());
        }

        [HttpPost]
        public IActionResult RegistrarCliente([FromBody] Cliente cliente)
        {
            var nuevo = clienteService.RegistrarCliente(cliente);
            return Ok(nuevo);
        }
    }
}