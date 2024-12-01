using Logica.Clases.Extra;
using Microsoft.Windows.Themes;
using System;
using System.Configuration;

namespace VetenProyect
{
    public partial class PlanearCita1 : Form
    {
        public PlanearCita1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public decimal Price;
        public string ClientName;

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
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form.Tag;
            form.BringToFront();
            form.Show();

        }

        private void CloseForms()
        {
            if (activeForm != null)
                panel1.Controls.Remove(activeForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(petName.Text) || string.IsNullOrEmpty(petState.Text) || 
                string.IsNullOrEmpty(reason.Text) || string.IsNullOrEmpty(petDescription.Text) || string.IsNullOrEmpty(petStateDescription.Text) )
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlanearCita2 f4 = new PlanearCita2();

            switch (reason.Text)
            {
                case "Consulta General (Chequeo de salud)":
                    Price = 3000;
                    break;
                case "Vacunación":
                    Price = 2000;
                    break;
                case "Desparacitación":
                    Price = 2500;
                    break;
                case "Emergencias":
                    Price = 4000;
                    break;
                case "Consulta de Dermatología(Problemas de piel)":
                    Price = 3500;
                    break;
                case "Consulta Odontológica":
                    Price = 3000;
                    break;
                case "Chequeo para Esterilización / Castración":
                    Price = 4500;
                    break;
                case "Exámenes de Laboratorio(Análisis de sangre, orina, etc.)":
                    Price = 3800;
                    break;
                case "Consulta de Comportamiento":
                    Price = 3200;
                    break;
                case "Atención Geriátrica":
                    Price = 2800;
                    break;
                case "Cirugía":
                    Price = 5000;
                    break;
                case "Atención de Urgencias Quirúrgicas":
                    Price = 4800;
                    break;
                case "Seguimiento Postoperatorio":
                    Price = 2300;
                    break;
                case "Consulta de Nutrición":
                    Price = 2700;
                    break;
                default:
                    MessageBox.Show("Seleccione un Tipo de cita valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Price = 0;
                    break;

            }

            f4.price = Price;
            f4.clientName = clientName.Text;
            f4.petName = petName.Text;
            f4.reasonDescription = petStateDescription.Text;
            f4.petDescription = petDescription.Text;
            f4.TipoCita = reason.Text;
            f4.petState = petState.Text;
            panel1.BringToFront();
            OpenForm(f4);

            clientName.Text = "";
            petName.Text = "";
            petStateDescription.Text = "";
            petDescription.Text = "";
            reason.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlanearCita1_Load(object sender, EventArgs e)
        {
            clientName.Text = ClientName;

            Mascota Mascota = new("", "", "", 0, "");
            List<string> mascotas = Mascota.getMascotas(ClientName);

            if (mascotas.Count == 0){
                mascotas.Add("No se han encontrado mascotas");
            }

            foreach (string mascota in mascotas)
            {
                petName.Items.Add(mascota);
            }
        }
    }
}
