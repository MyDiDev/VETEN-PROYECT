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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayServiceForm f9 = new PayServiceForm();
            f9.serviceLabel.Text = serviceLabel.Text;
            f9.servicePriceLabel.Text = priceServiceLabel.Text;
            f9.ShowDialog();
        }

        // Metodos para el manejo de servicios
    }
}
