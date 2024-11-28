using Datos;

namespace Logica.Clases.Registros
{
    public class Cita
    {
        private string NombreCliente;
        private string NombreMascota;
        private string NombrePersonal;
        private DateTime fecha;
        private string tipoServicio;
        private string estado;
        private string observaciones;

        public Cita(string nombreCliente, string nombreMascota, string nombrePersonal, DateTime Fecha, string TipoServicio, string Estado, string Observaciones)
        {
            NombreCliente = nombreCliente;
            NombreMascota = nombreMascota;
            NombrePersonal = nombrePersonal;
            fecha = Fecha;
            tipoServicio = TipoServicio;
            estado = Estado;
            observaciones = Observaciones;
        }

        Connection connection = new Connection();

        public string planearCita()
        {
            return connection.PlanearCita(NombreCliente, NombreMascota, NombrePersonal, fecha, tipoServicio, estado, observaciones);
        }
    }
}
