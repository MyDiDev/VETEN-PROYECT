using Logica.Clases.Registros;

namespace VetenProyect
{
    public partial class PlanearCita2 : Form
    {
        public PlanearCita2()
        {
            InitializeComponent();
        }

        public string TipoCita;


        private Form activeForm = null;

        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
                return;
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            panel1.Tag = form.Tag;
            form.BringToFront();
            form.Show();
        }

        private void CloseForms()
        {
            if (activeForm != null)
            {
                panel1.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = date.Value;
            DateTime now = DateTime.Now;
            if (string.IsNullOrEmpty(doctors.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (selectedDate < now || selectedDate == now)
            {
                MessageBox.Show("Solo se puede seleccionar una fecha mayor a la de Hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlanearCita3 f5 = new PlanearCita3();
            panel1.BringToFront();
            OpenForm(f5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PlanearCita2_Load(object sender, EventArgs e)
        {
            Personal personal = new();
            List<string> Doctors = personal.getPersonal(TipoCita);
            doctors.Items.Clear();
            foreach (string item in Doctors)
            {
                doctors.Items.Add(item);
            }
        }
    }
}
