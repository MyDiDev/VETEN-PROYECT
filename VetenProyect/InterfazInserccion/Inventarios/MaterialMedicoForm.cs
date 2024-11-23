using Logica.Clases.Historiales;

namespace VetenProyect.InterfazInserccion
{
    public partial class MaterialMedicoForm : Form
    {
        public MaterialMedicoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal UnitaryPrice = -1;
            int Amount = -1;
            DateTime selectedDate = checkDate.Value;
            DateTime today = DateTime.Today;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(description.Text)
                || string.IsNullOrEmpty(unitaryPrice.Text))
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

            if (today > selectedDate || selectedDate == today)
            {
                MessageBox.Show("Ingrese Una fecha Valida de expiracion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MaterialMedicoEquipamiento material = new(name.Text, description.Text, Amount, selectedDate, UnitaryPrice);
            if (material.agregarMaterialMedicoEquipamiento() == true) { MessageBox.Show("Material Medico o Equipamiento Agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show("ERROR: no se pudo agregar el Material Medico o Equipamiento\nIntente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}