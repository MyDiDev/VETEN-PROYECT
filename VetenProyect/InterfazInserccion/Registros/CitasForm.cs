using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            int IDClient;
            int IDPet;
            int IDPersonal;
            DateTime dateSelected = DatePlanned.Value;
            DateTime now = DateTime.Now;
            if (string.IsNullOrEmpty(idClient.Text) || string.IsNullOrEmpty(idPet.Text) || string.IsNullOrEmpty(IdPersonal.Text)
                || string.IsNullOrEmpty(serviceType.Text) || string.IsNullOrEmpty(petState.Text) || string.IsNullOrEmpty(observaciones.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IDClient = Convert.ToInt32(idClient.Text);
                IDPet = Convert.ToInt32(idPet.Text);
                IDPersonal = Convert.ToInt32(IdPersonal.Text);
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

            Cita cita = new(IDClient, IDPet, IDPersonal, dateSelected, serviceType.Text, petState.Text, observaciones.Text); 
            if (cita.planearCita() == true) { MessageBox.Show("Registro de Cita agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Error al agregar registro de cita, intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}