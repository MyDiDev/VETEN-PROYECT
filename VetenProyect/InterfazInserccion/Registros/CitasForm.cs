using Logica.Clases.Registros;

namespace VetenProyect.InterfazInserccion.Registros
{
    public partial class CitasForm : Form
    {
        public CitasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDPet;
            int IDPersonal;
            DateTime dateSelected = DatePlanned.Value;
            DateTime now = DateTime.Now;
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(petName.Text) || string.IsNullOrEmpty(personalName.Text)
                || string.IsNullOrEmpty(serviceType.Text) || string.IsNullOrEmpty(petState.Text) || string.IsNullOrEmpty(observaciones.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IDPet = Convert.ToInt32(petName.Text);
                IDPersonal = Convert.ToInt32(personalName.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese identficadores validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (now > dateSelected)
            {
                MessageBox.Show("Seleccione una fecha valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cita cita = new(clientName.Text, petName.Text, personalName.Text, dateSelected, serviceType.Text, petState.Text, observaciones.Text);
            string result = cita.planearCita();

            if (result == "1") { MessageBox.Show("Registro de Cita agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else { MessageBox.Show($"ERROR: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CitasForm_Load(object sender, EventArgs e)
        {

        }
    }
}