using Datos;

namespace Logica.Clases.Registros
{
    public class Proveedor
    {

        public string Nombre_Proveedor;
        public string Contacto;
        public string Telefono;
        public string Email;
        public string Direccion;
        public string Condiciones_Entrega;

        public Proveedor(
            string nombreProveedor,
            string contacto,
            string telefono,
            string email,
            string direccion,
            string condicionesEntrega)
        {
            Nombre_Proveedor = nombreProveedor;
            Contacto = contacto;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Condiciones_Entrega = condicionesEntrega;
        }

        Connection connection = new();

        public bool agregarProveedor()
        {
            return connection.AgregarProveedor(Nombre_Proveedor, Contacto, Telefono, Email, Direccion, Condiciones_Entrega);
        }
    }
}
