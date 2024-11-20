using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int IdCliente;

        public Pacientes(string nombre, string especie, string raza, int edad, string genero, int idCliente)
        {
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            Genero = genero;
            IdCliente = idCliente;
        }

        Connection connection = new();

        public bool agregarPaciente()
        {
            return connection.AgregarPaciente(Nombre, Especie, Raza, Edad, Genero, IdCliente);
        }
    }
}
