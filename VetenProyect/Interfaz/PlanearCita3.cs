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
    public partial class PlanearCita3 : Form
    {
        public PlanearCita3()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cita cita = new("datos de la cita");
            //cita.PlanearCita();
            Close();
        }
    }
}
