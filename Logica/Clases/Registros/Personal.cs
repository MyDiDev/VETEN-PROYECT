using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica.Clases.Registros
{
    public class Personal
    {
        public string Nombre;
        public string Cargo;
        public string Telefono;
        public string Email;
        public string Horario_Trabajo;
        public string Certificaciones;

        public Personal(string nombre, string cargo, string telefono, string email, string horario_Trabajo, string certificaciones)
        {
            Nombre = nombre;
            Cargo = cargo;
            Telefono = telefono;
            Email = email;
            Horario_Trabajo = horario_Trabajo;
            Certificaciones = certificaciones;
        }

        Connection connection = new();

        public bool agregarPersonal()
        {
            return connection.AgregarPersonal(Nombre, Cargo, Telefono, Email, Horario_Trabajo, Certificaciones);
        }
    }
}
