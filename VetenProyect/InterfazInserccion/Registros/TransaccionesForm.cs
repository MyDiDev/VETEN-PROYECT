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
            int IdClient;
            if (string.IsNullOrEmpty(idClient.Text) || string.IsNullOrEmpty(type.Text) || string.IsNullOrEmpty(Paymethod.Text)
                || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(state.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               Amount = Convert.ToDecimal(amount.Text);
               IdClient = Convert.ToInt32(idClient.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese identficadores validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transacciones transaccion = new(IdClient, DatePlanned.Value, type.Text, Paymethod.Text, Amount, description.Text, state.Text);
            if (transaccion.agregarTransaccion() == true) { MessageBox.Show("Registro de Transaccion agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show("Error al agregar registro de transaccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
