using Microsoft.Windows.Themes;
using System;

namespace VetenProyect
{
    public partial class PlanearCita1 : Form
    {
        public PlanearCita1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

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
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(petName.Text) || 
                string.IsNullOrEmpty(reason.Text) || string.IsNullOrEmpty(petDescription.Text) || string.IsNullOrEmpty(petStateDescription.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlanearCita2 f4 = new PlanearCita2();
            f4.Cargo = reason.Text;
            panel1.BringToFront();
            OpenForm(f4);
        }
    }
}
