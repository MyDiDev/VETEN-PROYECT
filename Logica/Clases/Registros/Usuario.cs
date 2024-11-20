using Datos;

namespace Logica.Clases.Registros
{
    public class Usuario
    {
        string nombre;
        string direccion;
        string telefono;
        string email;
        string clave;

        public Usuario(string nombre, string direccion, string telefono, string email, string clave)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

            this.clave = clave;
        }

        Connection connection = new Connection();

        public bool agregarUsuario(string userType)
        {
            return connection.AgregarUsuario(userType, nombre, direccion, telefono, email, clave);
        }

    }
}
