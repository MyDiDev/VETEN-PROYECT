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
    public partial class ProductoForn : Form
    {
        public ProductoForn()
        {
            InitializeComponent();

            MaximizeBox = false;
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
            panel2.Controls.Add(form);
            panel2.Tag = form;
            infoLabel.SendToBack();
            productLabel.SendToBack();
            priceLabel.SendToBack();
            label3.SendToBack();
            button1.SendToBack();
            productImage.SendToBack();
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayServiceForm f9 = new PayServiceForm();

            f9.serviceLabel.Text = productLabel.Text;
            f9.servicePriceLabel.Text = priceLabel.Text;

            OpenForm(f9);
        }

        //metodos para la compra con el producto
    }
}
