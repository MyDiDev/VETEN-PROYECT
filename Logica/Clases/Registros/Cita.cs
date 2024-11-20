using Datos;

namespace Logica.Clases.Registros
{
    public class Cita
    {
        private int idCliente;
        private int idMascota;
        private int idPersonal;
        private DateTime fecha;
        private string tipoServicio;
        private string estado;
        private string observaciones;

        public Cita(int IdCliente, int IdMascota, int IdPersonal, DateTime Fecha, string TipoServicio, string Estado, string Observaciones)
        {
            idCliente = IdCliente;
            idMascota = IdMascota;
            idPersonal = IdPersonal;
            fecha = Fecha;
            tipoServicio = TipoServicio;
            estado = Estado;
            observaciones = Observaciones;
        }

        Connection connection = new Connection();

        public bool planearCita()
        {
            return connection.PlanearCita(idCliente, idMascota, idPersonal, fecha, tipoServicio, estado, observaciones);
        }
    }
}
