using System;
using System.Collections.Generic;
using System.ComponentModel;
using Logica.Clases.Inventarios;

namespace VetenProyect.InterfazInserccion.Inventarios
{
    public partial class AddProductosForm : Form
    {
        public AddProductosForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = name.Text;
            string Descripcion = description.Text;
            int idProveedor = Convert.ToInt32(IdProveedor.Text);
            double precioUnitario = Convert.ToDouble(unitaryPrice.Text);
            int cantidad = Convert.ToInt32(amount.Text);

            Productos productos = new Productos(Nombre, Descripcion, idProveedor, precioUnitario, cantidad);
            if (productos.agregarProducto() == true) { MessageBox.Show("Producto Agregado Correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show("Error: El ID proveedor no esta registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
