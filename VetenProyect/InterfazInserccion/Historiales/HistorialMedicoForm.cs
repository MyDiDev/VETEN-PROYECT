using Logica.Clases.Historiales;

namespace VetenProyect.InterfazInserccion.Historiales
{
    public partial class HistorialMedicoForm : Form
    {
        public HistorialMedicoForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPaciente.Text) || string.IsNullOrEmpty(notes.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HistorialMedico historialMedico = new(idPaciente.Text, date.Value, notes.Text);
            string result = historialMedico.agregarHistorialMedico();

            if (result == "1")
            {
                MessageBox.Show("Registro de Historial medico agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"ERROR: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
