using Datos;

namespace Logica.Clases.Historiales
{
    public class Pacientes
    {
        public string Nombre;
        public string Especie;
        public string Raza;
        public int Edad;
        public string Genero;
        public string NombreCliente;

        public Pacientes(string nombre, string especie, string raza, int edad, string genero, string nombreCliente)
        {
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            Genero = genero;
            NombreCliente = nombreCliente;
        }

        Connection connection = new();

        public string agregarPaciente()
        {
            return connection.AgregarPaciente(Nombre, Especie, Raza, Edad, Genero, NombreCliente);
        }
    }
}
