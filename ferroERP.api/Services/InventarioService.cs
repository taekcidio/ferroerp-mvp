using ferroERP.api.Models;

namespace ferroERP.api.Services
{
    public class InventarioService
    {
        private static List<Producto> productos = new List<Producto>();

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public Producto RegistrarProducto(Producto producto)
        {
            producto.Id = productos.Count + 1;
            productos.Add(producto);
            return producto;
        }

        public bool EntradaStock(int id, int cantidad)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto == null) return false;

            producto.Stock += cantidad;
            return true;
        }

        public bool SalidaStock(int id, int cantidad)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto == null || producto.Stock < cantidad)
                return false;

            producto.Stock -= cantidad;
            return true;
        }
    }
}