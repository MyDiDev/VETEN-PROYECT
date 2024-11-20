using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Media.Media3D;
using Logica.Clases.Historiales;
using Microsoft.VisualBasic;

namespace VetenProyect.InterfazInserccion.Inventarios
{
    public partial class DocumentosAdministrativosForm : Form
    {
        public DocumentosAdministrativosForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateCreated = dateCreated.Value;
            DateTime DateUpdated = dateUpdated.Value;
            DateTime today = DateTime.Today;
            int Amount = -1;
            decimal UnitaryPrice = -1;
            int IDProveedor = -1;

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(type.Text) || string.IsNullOrEmpty(format.Text)
                || string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(location.Text) || string.IsNullOrEmpty(IdProveedor.Text) || string.IsNullOrEmpty(unitaryPrice.Text))
            {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Amount = Convert.ToInt32(amount.Text);
                UnitaryPrice = Convert.ToDecimal(unitaryPrice.Text);
                IDProveedor = Convert.ToInt32(IdProveedor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese Valores Validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateCreated > today ||  DateUpdated > today)
            {
                MessageBox.Show("Ingrese Una fecha Valida de expiracion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DocumentosAdministrativos documentos = new(name.Text, type.Text, description.Text, Amount, format.Text, DateCreated, DateUpdated, location.Text, UnitaryPrice, IDProveedor);
            if (documentos.agregarDocumentoAdmin() == true) { MessageBox.Show("Documento Agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show("ERROR: no se pudo agregar el Documento\nIntente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
