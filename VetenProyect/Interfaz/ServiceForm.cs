using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace VetenProyect
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public string ClientName;

        private void Form11_Load(object sender, EventArgs e)
        {
            clientName.Text = ClientName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientName.Text) || string.IsNullOrEmpty(pets.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PayServiceForm f9 = new PayServiceForm();
            f9.serviceLabel.Text = serviceLabel.Text;
            f9.servicePriceLabel.Text = priceServiceLabel.Text;
            f9.clientName = clientName.Text;
            f9.petName = pets.Text;
            f9.date = date.Value;
            f9.ShowDialog();
        }

        // Metodos para el manejo de servicios
    }
}
