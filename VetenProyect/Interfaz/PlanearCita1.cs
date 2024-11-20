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
    public partial class PlanearCita1 : Form
    {
        public PlanearCita1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(animalBox.Text) || string.IsNullOrEmpty(animalTypeBox.Text)
                || string.IsNullOrEmpty(animalTypeRbox.Text) || string.IsNullOrEmpty(animalAge.Text) ||
                string.IsNullOrEmpty(animalGender.Text) || string.IsNullOrEmpty(animalWeight.Text) ||
                string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(userEmail.Text)
                )
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            PlanearCita2 f4 = new PlanearCita2();
            f4.ShowDialog();
            Close();
        }
    }
}
