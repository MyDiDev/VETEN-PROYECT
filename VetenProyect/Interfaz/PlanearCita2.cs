using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetenProyect
{
    public partial class PlanearCita2 : Form
    {
        public PlanearCita2()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(appointmentReason.Text) || string.IsNullOrEmpty(appointmentDoctor.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PlanearCita3 f5 = new PlanearCita3();
            f5.ShowDialog();
            Close();
        }
    }
}
