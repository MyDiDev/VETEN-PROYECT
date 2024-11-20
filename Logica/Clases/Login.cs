using Datos;

namespace Logica.Clases
{
    public class Login
    {
        public string userName;
        private string userPassword;

        public Login(string name, string password)
        {
            userName = name;
            userPassword = password;
        }

        Connection connection = new Connection();

        public string tipoUsuario()
        {
            return connection.UserType(userName, userPassword);
        }
    }
}
