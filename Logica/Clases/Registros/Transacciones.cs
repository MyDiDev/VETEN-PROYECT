using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica.Clases.Registros
{
    public class Transacciones
    {
        public int IdCliente;
        public DateTime FechaTransaccion;
        public string Tipo;
        public string MetodoPago;
        public decimal Monto;
        public string Descripcion;
        public string Estado;

        public Transacciones(int idCliente, DateTime fechaTransaccion, string tipo, string metodoPago, decimal monto, string descripcion, string estado)
        {
            IdCliente = idCliente;
            FechaTransaccion = fechaTransaccion;
            Tipo = tipo;
            MetodoPago = metodoPago;
            Monto = monto;
            Descripcion = descripcion;
            Estado = estado;
        }

        Connection connection = new();

        public bool agregarTransaccion()
        {
            return connection.AgregarTransaccion(IdCliente, FechaTransaccion, Tipo, MetodoPago, Monto, Descripcion, Estado);
        }
    }
}
