using Logica.Clases.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetenProyect.InterfazInserccion.Registros
{
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(cargo.Text) || string.IsNullOrEmpty(phone.Text)
                || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(HorarioTrabajo.Text) || string.IsNullOrEmpty(Certifications.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Personal personal = new(name.Text, cargo.Text, phone.Text, email.Text, HorarioTrabajo.Text, Certifications.Text);
            if(personal.agregarPersonal() == true) { MessageBox.Show("Registro de personal Agregado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show("Error Al agregar Registro, Intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}