using Logica.Clases.Registros;

namespace VetenProyect.InterfazInserccion.Registros
{
    public partial class TransaccionesForm : Form
    {
        public TransaccionesForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            decimal Amount;
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(type.Text) || string.IsNullOrEmpty(Paymethod.Text)
                || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(state.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               Amount = Convert.ToDecimal(amount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese identficadores validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transacciones transaccion = new(clientName.Text, DatePlanned.Value, type.Text, Paymethod.Text, Amount, description.Text, state.Text);
            string result = transaccion.agregarTransaccion();

            if (result == "1") { MessageBox.Show("Registro de Transaccion agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show($"ERROR: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
