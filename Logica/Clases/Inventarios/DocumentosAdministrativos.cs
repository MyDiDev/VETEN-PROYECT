using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica.Clases.Historiales
{
    public class DocumentosAdministrativos
    {
        public string Nombre;
        public string Tipo;
        public string Descripcion;
        public int Cantidad;
        public string Formato;
        public DateTime FechaCreacion;
        public DateTime FechaActualizacion;
        public string Ubicacion;
        public decimal PrecioUnitario;
        public int IDProveedor;

        public DocumentosAdministrativos(string nombre, string tipo, string descripcion, int cantidad, string formato, DateTime fechaCreacion, DateTime fechaActualizacion, string ubicacion, decimal precioUnitario, int iDProveedor)
        {
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Formato = formato;
            FechaCreacion = fechaCreacion;
            FechaActualizacion = fechaActualizacion;
            Ubicacion = ubicacion;
            PrecioUnitario = precioUnitario;
            IDProveedor = iDProveedor;
        }

        Connection connection = new();

        public bool agregarDocumentoAdmin()
        {
            return connection.AgregarDocumentoAdmin(Nombre, Tipo, Descripcion, Cantidad, Formato, FechaCreacion, FechaActualizacion, Ubicacion, PrecioUnitario, IDProveedor);
        }
    }
}
