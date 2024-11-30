using Logica.Clases.Extra;
using VetenProyect.Interfaz;

namespace VetenProyect
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = nameBoxF1.Text.Trim();
            string Password = passBoxF1.Text.Trim();


            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Login userLog = new Login(Name, Password);
            Form14 main = new Form14();

            if (userLog.tipoUsuario().ToUpper() == "USUARIO")
            {
                MessageBox.Show("Registro Encontrado!\nBienvenido Usuario", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.adminMark.Visible = false;
                main.clientName = Name;
                main.Show();
                Hide();
            }
            else if (userLog.tipoUsuario().ToUpper() == "ADMIN")
            {
                MessageBox.Show("Registro Encontrado!\nBienvenido Administrador", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.adminMark.Visible = true;
                main.btnInventario.Visible = true;
                main.btnHistoriales.Visible = true;
                main.iconButton7.Visible = true;
                main.clientName = Name;
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Registro NO Encontrado\nIntente Nuevamente o Registrese al sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm rf = new();
            rf.ShowDialog();
        }
    }
}
