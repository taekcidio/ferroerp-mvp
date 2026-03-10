using ferroERP.api.Models;

namespace ferroERP.api.Services
{
    public class ClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public Cliente RegistrarCliente(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;
            clientes.Add(cliente);
            return cliente;
        }
    }
}
