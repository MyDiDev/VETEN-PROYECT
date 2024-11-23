using Datos;

namespace Logica.Clases.Historiales
{
    public class HistorialMedico
    {

        public int IdPaciente;
        public DateTime Fecha;
        public string NotasGenerales;

        public HistorialMedico(int idPaciente, DateTime fecha, string notasGenerales)
        {
            IdPaciente = idPaciente;
            Fecha = fecha;
            NotasGenerales = notasGenerales;
        }

        Connection connection = new();

        public bool agregarHistorialMedico()
        {
            return connection.AgregarHistorialMedico(IdPaciente, Fecha, NotasGenerales);
        }
    }
}
