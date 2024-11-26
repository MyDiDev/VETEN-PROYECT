using Datos;
using System.Data;

namespace Logica.Clases.Extra
{
    public class CitasRecordatorios
    {
        private DateTime FechaHora;
        private string Tipo;
        private string Motivo;
        private string Descripcion;
        private string Estado;


        public CitasRecordatorios(DateTime fechaHora, string tipo,
                                  string motivo, string descripcion, string estado)
        {
            FechaHora = fechaHora;
            Tipo = tipo;
            Motivo = motivo;
            Descripcion = descripcion;
            Estado = estado;
        }

        Connection connection = new();

        public string agregregarCitaRecordatorio(string nombreCliente, string nombreMascota)
        {
            return connection.AgregarCitaRecordatorio(FechaHora, Tipo, nombreCliente, nombreMascota, Motivo, Descripcion, Estado);
        }

        public DataTable getCitasRecordatorios(int IDCliente, int IDMascota)
        {
            return connection.GetCitasRecordatorios(IDCliente, IDMascota);
        }
    }
}
