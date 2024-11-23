using Logica.Clases.Historiales;
using System.Diagnostics.CodeAnalysis;

namespace VetenProyect.InterfazInserccion.Historiales
{
    public partial class DiagnosticoForm : Form
    {
        public DiagnosticoForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int IdVisit = -1;
            
            if (string.IsNullOrEmpty(idVisit.Text) || string.IsNullOrEmpty(description.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IdVisit = Convert.ToInt32(idVisit.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un id de visita Valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Diagnosticos diagnostico = new(IdVisit, description.Text, date.Value);
            if (diagnostico.agregarDiagnostico() == true)
            {
                MessageBox.Show("Historial de diagnostico agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar registro, intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
