using Datos;

namespace Logica.Clases.Extra
{
    public class Mascota
    {
        private string Nombre;
        private string Especie;
        private string Raza;
        private int Edad;
        private string Genero;

        public Mascota(string nombre, string especie, string raza, int edad, string genero)
        {
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Edad = edad;
            Genero = genero;
        }

        Connection connection = new Connection();

        public string agregarMascota(string nombreCliente)
        {
            return connection.AgregarMascota(nombreCliente, Nombre, Especie, Raza, Edad, Genero);
        }

        public int conseguirId(string Tabla, string ColumnaTarget, string ColumnaWhere, string ValorWhere)
        {
            return connection.ConseguirId(Tabla, ColumnaTarget, ColumnaWhere, ValorWhere);
        }
    }
}
