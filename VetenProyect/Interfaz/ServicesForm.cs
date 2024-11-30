using Logica.Clases.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetenProyect.Interfaz
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        public ServiceForm f8 = new ServiceForm();
        public string clientName;

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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            f8.serviceLabel.Text = "CONSULTA GENERAL Y DIAGNOSTICO";
            f8.serviceImage.Image = null;
            f8.serviceImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\diagnostic_and_analisys_img.png");
            panel1.BringToFront();
            OpenForm(f8);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            f8.serviceLabel.Text = "CIRUGIA DE ESTERIZALISACION/CASTRACION";
            f8.serviceImage.Image = null;
            f8.serviceImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\veterinarian_img.png");
            panel1.BringToFront();
            OpenForm(f8);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            f8.serviceLabel.Text = "RADIOGRAFIA VETERINARIA";
            f8.serviceImage.Image = null;
            f8.serviceImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\veterinarian_xray.png");
            panel1.BringToFront();
            OpenForm(f8);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            f8.serviceLabel.Text = "VACUNACION Y DESPARASITACION";
            f8.serviceImage.Image = null;
            f8.serviceImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\vacuna_img.png");
            panel1.BringToFront();
            OpenForm(f8);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            Mascota Mascota = new("", "", "",0,"");
            List<string> mascotas = Mascota.getMascotas(clientName);

            if (mascotas.Count == 0)
            {
                f8.pets.Items.Add("No se han encontrado mascotas");
                return;
            }
            else {
                foreach (string mascota in mascotas)
                {
                    f8.pets.Items.Add(mascota);
                }
            }


        }
    }
}
