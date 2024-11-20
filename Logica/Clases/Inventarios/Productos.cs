using Datos;

namespace Logica.Clases.Inventarios
{
    public class Productos
    {

        private string Nombre;
        private string Descripcion;
        private int ID_Proveedor;
        private double Precio_Unitario;
        private int Cantidad;

        public Productos(
            string nombre,
            string descripcion,
            int idProveedor,
            double precioUnitario,
            int cantidad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            ID_Proveedor = idProveedor;
            Precio_Unitario = precioUnitario;
            Cantidad = cantidad;
        }

        Connection connection = new();

        public bool agregarProducto()
        {
            return connection.AgregarProducto(Nombre, Descripcion, ID_Proveedor, Precio_Unitario, Cantidad);
        }
    }
}
