using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.Clases.Inventarios;

namespace VetenProyect.InterfazInserccion
{
    public partial class MedicamentoVacunaForm : Form
    {
        public MedicamentoVacunaForm()
        {
            InitializeComponent();
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void expiredDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = expiredDate.Value;
            DateTime today = DateTime.Today;
            int Amount = -1;
            decimal UnitaryPrice = -1;

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(recommendDosis.Text) || string.IsNullOrEmpty(lote.Text)
                || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(unitaryPrice.Text))
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

            if (today > selectedDate || selectedDate == today )
            {
                MessageBox.Show("Ingrese Una fecha Valida de expiracion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MedicamentosVacunas medicamentosVacunas = new(name.Text, description.Text, lote.Text, selectedDate, recommendDosis.Text, Amount, UnitaryPrice);
            if (medicamentosVacunas.agregarMedicamentoVacuna() == true) { MessageBox.Show("Medicamento/Vacuna Agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show("ERROR: no se pudo agregar el Medicamento/Vacuna\nIntente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}