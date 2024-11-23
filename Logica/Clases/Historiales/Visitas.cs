using Datos;

namespace Logica.Clases.Historiales
{
    public class Visitas
    {

        public DateTime FechaVisita;
        public string Motivo;
        public decimal Peso;
        public decimal Temperatura;
        public string Notas;

        public Visitas(DateTime fechaVisita, string motivo, decimal peso, decimal temperatura, string notas)
        {
            FechaVisita = fechaVisita;
            Motivo = motivo;
            Peso = peso;
            Temperatura = temperatura;
            Notas = notas;
        }

        Connection connection = new();

        public bool agregarVisita()
        {
            return connection.AgregarVisita(FechaVisita, Motivo, Peso, Temperatura, Notas);
        }
    }
}
