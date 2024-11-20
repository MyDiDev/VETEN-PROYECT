using Logica.Clases.Registros;

namespace VetenProyect
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(addressBox.Text)
                || string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(emailBox.Text) || string.IsNullOrEmpty(passBox.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario(nameBox.Text, addressBox.Text, phoneBox.Text, emailBox.Text, passBox.Text);
            usuario.agregarUsuario("ADMIN");

        }
    }
}
