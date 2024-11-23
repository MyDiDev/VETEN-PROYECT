using Logica.Clases.Historiales;

namespace VetenProyect.InterfazInserccion
{
    public partial class AlimentosSuplementosForm : Form
    {
        public AlimentosSuplementosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Amount = -1;
            decimal UnitaryPrice = -1;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(unitaryPrice.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Amount = Convert.ToInt32(amount.Text);
                UnitaryPrice = Convert.ToDecimal(unitaryPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese Valores Validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlimentoSuplemento alimento = new(name.Text, description.Text, Amount, UnitaryPrice);
            if (alimento.agregarAlimentoSuplemento() == true) { MessageBox.Show("Alimento/Suplemento Agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show("ERROR: no se pudo agregar el Alimento/Suplemento\nIntente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
