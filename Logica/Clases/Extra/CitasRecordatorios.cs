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
        private bool NotificacionEnviada;
        private DateTime FechaNotificacion;
        private string Estado;
        private DateTime CreadoEn;
        private DateTime ActualizadoEn;

        public CitasRecordatorios(DateTime fechaHora, string tipo, int idCliente, int idMascota,
                                  string motivo, string descripcion, bool notificacionEnviada,
                                  DateTime fechaNotificacion, string estado, DateTime creadoEn, DateTime actualizadoEn)
        {
            FechaHora = fechaHora;
            Tipo = tipo;
            IDCliente = idCliente;
            IDMascota = idMascota;
            Motivo = motivo;
            Descripcion = descripcion;
            NotificacionEnviada = notificacionEnviada;
            FechaNotificacion = fechaNotificacion;
            Estado = estado;
            CreadoEn = creadoEn;
            ActualizadoEn = actualizadoEn;
        }

        Connection connection = new();

        public bool agregregarCitaRecordatorio()
        {
            return connection.AgregarCitaRecordatorio(FechaHora, Tipo, IDCliente, IDMascota, Motivo, Descripcion, NotificacionEnviada, FechaNotificacion, Estado, CreadoEn, ActualizadoEn);
        }

        public DataTable getCitasRecordatorios(int IDCliente, int IDMascota)
        {
            return connection.GetCitasRecordatorios(IDCliente, IDMascota);
        }
    }
}
