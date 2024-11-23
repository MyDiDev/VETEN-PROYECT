using Datos;
using System.Data;

namespace Logica.Clases.Extra
{
    public class CitasRecordatorios
    {
        private DateTime FechaHora;
        private string Tipo;
        private int IDCliente;
        private int IDMascota;
        private string Motivo;
        private string Descripcion;
        private string Estado;


        public CitasRecordatorios(DateTime fechaHora, string tipo, int idCliente, int idMascota,
                                  string motivo, string descripcion, string estado)
        {
            FechaHora = fechaHora;
            Tipo = tipo;
            IDCliente = idCliente;
            IDMascota = idMascota;
            Motivo = motivo;
            Descripcion = descripcion;
            Estado = estado;
        }

        Connection connection = new();

        public bool agregregarCitaRecordatorio()
        {
            return connection.AgregarCitaRecordatorio(FechaHora, Tipo, IDCliente, IDMascota, Motivo, Descripcion, Estado);
        }

        public DataTable getCitasRecordatorios(int IDCliente, int IDMascota)
        {
            return connection.GetCitasRecordatorios(IDCliente, IDMascota);
        }
    }
}
