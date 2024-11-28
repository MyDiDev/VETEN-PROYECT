using Datos;

namespace Logica.Clases.Historiales
{
    public class HistorialMedico
    {

        public string NombrePaciente;
        public DateTime Fecha;
        public string NotasGenerales;

        public HistorialMedico(string nombrePaciente, DateTime fecha, string notasGenerales)
        {
            NombrePaciente = nombrePaciente;
            Fecha = fecha;
            NotasGenerales = notasGenerales;
        }

        Connection connection = new();

        public string agregarHistorialMedico()
        {
            return connection.AgregarHistorialMedico(NombrePaciente, Fecha, NotasGenerales);
        }
    }
}
