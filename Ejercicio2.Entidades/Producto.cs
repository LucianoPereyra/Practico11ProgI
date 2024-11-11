namespace Ejercicio2.Entidades
{
    public class Producto
    {

        public CategoriaProducto categoriaProducto { get; set; }

        public int CodigoProducto { get; set; }

        public string? DescripcionProducto { get; set; }

        public int CantidadProducto { get; set; }

        public int PrecioProducto { get; set; }
    }
}
