using Ejercicio2.Entidades;

namespace Ejercicio2.Datos
{
    public class RepositorioProductos
    {
        private List<Producto>? productos;

        public RepositorioProductos()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos!.Add(producto);
        }

        public List<Producto>? GetProductos() => productos;

        public void EliminarProducto(int codigoProducto)
        {
            var producto = productos!.FirstOrDefault(p => p.CodigoProducto == codigoProducto);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
    }

  
}
