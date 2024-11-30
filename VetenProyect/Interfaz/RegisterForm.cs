using Logica.Clases.Registros;

namespace VetenProyect
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(addressBox.Text)
                || string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(emailBox.Text) || string.IsNullOrEmpty(passBox.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios usuario = new Usuarios(nameBox.Text, addressBox.Text, phoneBox.Text, emailBox.Text, passBox.Text);
            if (usuario.agregarUsuario("USUARIO") == true) {
                MessageBox.Show("Usuario registrado a la aplicacion exitosamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                Close();
                return;
            }
            else
            {
                MessageBox.Show("No se pudo registrar, intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
