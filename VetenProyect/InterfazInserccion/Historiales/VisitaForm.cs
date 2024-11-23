using Logica.Clases.Historiales;

namespace VetenProyect.InterfazInserccion.Historiales
{
    public partial class VisitaForm : Form
    {
        public VisitaForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            decimal Wheight = 0;
            decimal Temperature = 0;
            if (string.IsNullOrEmpty(reazon.Text) || string.IsNullOrEmpty(wheight.Text) || string.IsNullOrEmpty(temperature.Text) ||
                string.IsNullOrEmpty(notes.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Wheight = Convert.ToDecimal(wheight.Text);
                Temperature = Convert.ToDecimal(temperature.Text);
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese temperatura/peso en un formato valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Visitas visita = new(date.Value, reazon.Text, Wheight, Temperature, notes.Text);
            if (visita.agregarVisita() == true) 
            {
                MessageBox.Show("Registro de Visita agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Agregar Registro de Visita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
