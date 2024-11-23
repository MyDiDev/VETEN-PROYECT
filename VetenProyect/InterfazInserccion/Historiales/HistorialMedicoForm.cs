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
            int IdPaciente = -1;
            if (string.IsNullOrEmpty(idPaciente.Text) || string.IsNullOrEmpty(notes.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IdPaciente = Convert.ToInt32(idPaciente.Text);
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese un id de paciente Valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HistorialMedico historialMedico = new(IdPaciente, date.Value, notes.Text);
            if (historialMedico.agregarHistorialMedico() == true)
            {
                MessageBox.Show("Registro de Historial medico agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar Registro de Historial medico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
