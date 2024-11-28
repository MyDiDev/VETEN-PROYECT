using Logica.Clases.Historiales;
using System.Xml.XPath;

namespace VetenProyect.InterfazInserccion.Historiales
{
    public partial class PacienteForm : Form
    {
        public PacienteForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int Age = 0;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(specie.Text) || string.IsNullOrEmpty(race.Text) ||
                string.IsNullOrEmpty(age.Text) || string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(clientName.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gender.Text != "Varon" && gender.Text != "Hembra")
            {
                MessageBox.Show("Seleccione un genero Valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Age = Convert.ToInt32(age.Text);
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese edad/id validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacientes paciente = new(name.Text, specie.Text, race.Text, Age, gender.Text, clientName.Text);
            string result = paciente.agregarPaciente();
            if (result == "1")
            {
                MessageBox.Show("Registro de Paciente agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"ERROR: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
