using Logica.Clases.Registros;

namespace VetenProyect.InterfazInserccion.Inventarios
{
    public partial class ProveedorForm : Form
    {
        public ProveedorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(contact.Text) || string.IsNullOrEmpty(mail.Text)
                || string.IsNullOrEmpty(direction.Text) || string.IsNullOrEmpty(condition.Text) || string.IsNullOrEmpty(phone.Text)) { 
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Proveedor proveedor = new(name.Text, contact.Text, phone.Text, mail.Text, direction.Text, condition.Text);
            if (proveedor.agregarProveedor() == true)
            {
                MessageBox.Show("Proveedor agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
