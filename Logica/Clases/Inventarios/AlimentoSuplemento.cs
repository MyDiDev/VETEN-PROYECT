using Datos;
using System.Diagnostics.CodeAnalysis;

namespace Logica.Clases.Historiales
{
    public class AlimentoSuplemento
    {
        public string Nombre;
        public string Descripcion;
        public int Cantidad;
        public decimal Precio_Unitario;

        public AlimentoSuplemento(
            string nombre,
            string descripcion,
            int cantidad,
            decimal precioUnitario)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio_Unitario = precioUnitario;
        }

        Connection connection = new();
        public bool agregarAlimentoSuplemento()
        {
            return connection.AgregarAlimentoSuplemento(Nombre, Descripcion, Cantidad, Precio_Unitario);
        }
    }
}
