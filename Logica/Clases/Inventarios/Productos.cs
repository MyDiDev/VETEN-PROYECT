using Datos;

namespace Logica.Clases.Inventarios
{
    public class Productos
    {

        private string Nombre;
        private string Descripcion;
        private string NombreProveedor;
        private double Precio_Unitario;
        private int Cantidad;

        public Productos(
            string nombre,
            string descripcion,
            string nombreProveedor,
            double precioUnitario,
            int cantidad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            NombreProveedor = nombreProveedor;
            Precio_Unitario = precioUnitario;
            Cantidad = cantidad;
        }

        Connection connection = new();

        public string agregarProducto()
        {
            return connection.AgregarProducto(Nombre, Descripcion, NombreProveedor, Precio_Unitario, Cantidad);
        }

        public string getProductoPrice(string nombreProducto)
        {
            return connection.GetProductoPrice(nombreProducto);
        }
    }
}
