using FontAwesome.Sharp;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace VetenProyect.Interfaz
{
    public partial class Form14 : Form
    {

        private IconButton currentBtn;

        public Form14()
        {
            InitializeComponent();
            MinimumSize = new Size(874, 504);
        }

        private Form activeForm = null;
        private void OpenForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            formPanel.Controls.Add(form);
            formPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void CloseForm()
        {
            if (activeForm != null)
                activeForm.Close();
                
            formPanel.Controls.Remove(activeForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));

            Form15 form = new();
            OpenForm(form);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));

            Form13 f13 = new();
            OpenForm(f13);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));

            ServicesForm form = new();
            OpenForm(form);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));

            DataForm f10 = new DataForm();
            f10.adminTaskTypeLabel.Text = "INVENTARIOS";
            f10.btn1.Text = "MEDICAMENTOS Y VACUNAS";
            f10.btn2.Text = "MATERIAL MEDICO Y EQUIPAMIENTO";
            f10.btn3.Text = "ALIMENTOS Y SUPLEMENTOS";
            f10.btn4.Text = "DOCUMENTOS Y MATERIAL ADMINISTRATIVO";
            f10.btn5.Text = "PRODUCTOS";
            OpenForm(f10);
        }

        private void btnHistoriales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));
            DataForm f10 = new DataForm();
            f10.adminTaskTypeLabel.Text = "HISTORIALES";
            f10.btn1.Text = "PACIENTES";
            //f10.btn2.Text = "DUEÑOS";
            f10.btn3.Text = "HISTORIAL MEDICO";
            f10.btn4.Text = "VISITAS";
            f10.btn5.Text = "DIAGNOSTICOS";
            OpenForm(f10);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));
            DataForm f10 = new DataForm();
            f10.adminTaskTypeLabel.Text = "REGISTROS";
            f10.btn1.Text = "CITAS";
            f10.btn2.Text = "CLIENTES";
            f10.btn3.Text = "PROVEEDORES";
            f10.btn4.Text = "PERSONAL";
            f10.btn5.Text = "PAGOS Y FACTURACION";
            OpenForm(f10);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
             
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(194, 255, 199));
            PlanearCita1 cita1 = new();
            OpenForm(cita1);
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(82, 110, 72);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
