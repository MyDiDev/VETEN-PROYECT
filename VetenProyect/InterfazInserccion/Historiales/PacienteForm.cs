using Logica.Clases.Historiales;

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
            int IdClient = -1;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(specie.Text) || string.IsNullOrEmpty(race.Text) ||
                string.IsNullOrEmpty(age.Text) || string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(idClient.Text))
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
                IdClient = Convert.ToInt32(idClient.Text);
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese edad/id validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacientes paciente = new(name.Text, specie.Text, race.Text, Age, gender.Text, IdClient);
            if (paciente.agregarPaciente() == true)
            {
                MessageBox.Show("Registro de Paciente agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar Registro de Paciente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
