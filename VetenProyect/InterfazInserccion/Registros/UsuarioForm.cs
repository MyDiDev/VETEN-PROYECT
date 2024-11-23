using Logica.Clases.Registros;

namespace VetenProyect.InterfazInserccion.Registros
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(location.Text) || string.IsNullOrEmpty(phone.Text) 
                || phone.Text.Length > 9 || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(userType.Text))
                MessageBox.Show("Llene el formulario con el formato correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Usuarios usuario = new(name.Text, location.Text, phone.Text, email.Text, password.Text);
            if (usuario.agregarUsuario(userType.Text) == true){ MessageBox.Show("Usuario agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show("No se pudo agregar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
