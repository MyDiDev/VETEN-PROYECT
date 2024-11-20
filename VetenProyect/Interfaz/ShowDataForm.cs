using Datos;
using Logica.Clases.Interaccion_Datos;
using System.Diagnostics.CodeAnalysis;
using VetenProyect.InterfazInserccion;
using VetenProyect.InterfazInserccion.Inventarios;
using VetenProyect.InterfazInserccion.Registros;

namespace VetenProyect
{
    public partial class ShowDataForm : Form
    {
        public ShowDataForm()
        {
            InitializeComponent();
        }

        InDatos datos = new();
        Connection connection = new();
        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "MEDICAMENTOS Y VACUNAS":
                    MedicamentoVacunaForm medicamentoVacunaForm = new();
                    medicamentoVacunaForm.ShowDialog();
                    break;
                case "PACIENTES":

                    break;
                case "CITAS":
                    CitasForm citasForm = new();
                    citasForm.ShowDialog();
                    break;
                case "MATERIAL MEDICO Y EQUIPAMIENTO":
                    MaterialMedicoForm materialMedicoForm = new();
                    materialMedicoForm.ShowDialog();
                    break;
                case "CLIENTES":
                    
                    break;
                case "ALIMENTOS Y SUPLEMENTOS":
                    AlimentosSuplementosForm alimentosSuplementosForm = new();
                    alimentosSuplementosForm.ShowDialog();
                    break;
                case "HISTORIAL MEDICO":

                    break;
                case "PROVEEDORES":
                    ProveedorForm proveedorForm = new();
                    proveedorForm.ShowDialog();
                    break;
                case "PRODUCTOS":
                    Form15 productosForm = new();
                    productosForm.ShowDialog();
                    break;
                case "DIAGNOSTICOS":

                    break;
                case "PAGOS Y FACTURACION":

                    break;
                case "DOCUMENTOS Y MATERIAL ADMINISTRATIVO":
                    DocumentosAdministrativosForm documentoForm = new();
                    documentoForm.ShowDialog();
                    break;
                case "VISITAS":

                    break;
                case "PERSONAL":

                    break;
            }
            RecagarDatos();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = -1;
                string tabla = "";
                string columnaId = "";

                switch (label1.Text)
                {
                    case "MEDICAMENTOS Y VACUNAS":
                        tabla = "Medicamentos_Vacunas";
                        columnaId = "ID_Medicamento";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Medicamento"].Value);
                        break;

                    case "PACIENTES":
                        tabla = "Pacientes";
                        columnaId = "ID_Paciente";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Paciente"].Value);
                        break;

                    case "CITAS":
                        tabla = "Citas";
                        columnaId = "ID_Cita";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Cita"].Value);
                        break;

                    case "MATERIAL MEDICO Y EQUIPAMIENTO":
                        tabla = "Material_Medico_Equipamiento";
                        columnaId = "ID_Material";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Material"].Value);
                        break;

                    case "CLIENTES":
                        tabla = "Clientes";
                        columnaId = "ID_Cliente";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Cliente"].Value);
                        break;

                    case "ALIMENTOS Y SUPLEMENTOS":
                        tabla = "Alimentos_Suplementos";
                        columnaId = "ID_Alimento";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Alimento"].Value);
                        break;

                    case "HISTORIAL MEDICO":
                        tabla = "HistorialMedico";
                        columnaId = "ID_Historial";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Historial"].Value);
                        break;

                    case "PROVEEDORES":
                        tabla = "Proveedores";
                        columnaId = "ID_Proveedor";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Proveedor"].Value);
                        break;

                    case "PRODUCTOS":
                        tabla = "Productos_Generales";
                        columnaId = "ID_Producto";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Producto"].Value);
                        break;

                    case "DIAGNOSTICOS":
                        tabla = "Diagnosticos";
                        columnaId = "ID_Diagnostico";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Diagnostico"].Value);
                        break;

                    case "PAGOS Y FACTURACION":
                        tabla = "pagos_facturacion";
                        columnaId = "ID_Transaccion";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Transaccion"].Value);
                        break;

                    case "DOCUMENTOS Y MATERIAL ADMINISTRATIVO":
                        tabla = "Documentos_Materiales_Administrativos";
                        columnaId = "ID_Item";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Item"].Value);
                        break;

                    case "VISITAS":
                        tabla = "Visitas";
                        columnaId = "ID_Visita";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Visita"].Value);
                        break;

                    case "PERSONAL":
                        tabla = "Personal";
                        columnaId = "ID_Personal";
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Personal"].Value);
                        break;

                    default:
                        MessageBox.Show("Error, no se ha podido encontrar registro para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                DialogResult result = MessageBox.Show("Seguro que quieres eliminar el registro?", "ADVERTENCIA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); ;

                if (result == DialogResult.Yes)
                {
                    if (datos.eliminarRegistro(tabla, columnaId, id) == true) { MessageBox.Show("Registro eliminado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    return;
                }

                RecagarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Llene almenos una de las entradas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = -1;
            if (string.IsNullOrEmpty(textBox1.Text)) { Id = 0; }
            else
            {
                Id = Convert.ToInt32(textBox1.Text);
            }


            switch (label1.Text)
            {
                case "MEDICAMENTOS Y VACUNAS":
                    dataGridView1.DataSource = datos.buscarRegistro("Medicamentos_Vacunas", "Nombre", textBox2.Text, "ID_Medicamento", Id);
                    break;
                case "PACIENTES":
                    dataGridView1.DataSource = datos.buscarRegistro("Pacientes", "Nombre", textBox2.Text, "ID_Paciente", Id);
                    break;
                case "CITAS":
                    dataGridView1.DataSource = datos.buscarRegistro("Citas", "ID_Cita", Id);
                    break;
                case "MATERIAL MEDICO Y EQUIPAMIENTO":
                    dataGridView1.DataSource = datos.buscarRegistro("Material_Medico_Equipamiento", "Nombre", textBox2.Text, "ID_Material", Id);
                    break;
                case "CLIENTES":
                    dataGridView1.DataSource = datos.buscarRegistro("Clientes", "Nombre", textBox2.Text, "ID_Cliente", Id);
                    break;
                case "ALIMENTOS Y SUPLEMENTOS":
                    dataGridView1.DataSource = datos.buscarRegistro("Alimentos_Suplementos", "Nombre", textBox2.Text, "ID_Alimento", Id);
                    break;
                case "HISTORIAL MEDICO":
                    dataGridView1.DataSource = datos.buscarRegistro("HistorialMedico", "ID_Historial", Id);
                    break;
                case "PROVEEDORES":
                    dataGridView1.DataSource = datos.buscarRegistro("Proveedores", "Nombre_Proveedor", textBox2.Text, "ID_Proveedor", Id);
                    break;
                case "PRODUCTOS":
                    dataGridView1.DataSource = datos.buscarRegistro("Productos_Generales", "Nombre", textBox2.Text, "ID_Producto", Id);
                    break;
                case "DIAGNOSTICOS":
                    dataGridView1.DataSource = datos.buscarRegistro("Diagnosticos", "ID_Diagnostico", Id);
                    break;
                case "PAGOS Y FACTURACION":
                    dataGridView1.DataSource = datos.buscarRegistro("Transacciones", "ID_Transaccion", Id);
                    break;
                case "DOCUMENTOS Y MATERIAL ADMINISTRATIVO":
                    dataGridView1.DataSource = datos.buscarRegistro("Documentos_Materiales_Administrativos", "Nombre", textBox1.Text, "ID_Item", Id);
                    break;
                case "VISITAS":
                    dataGridView1.DataSource = datos.buscarRegistro("Visitas", "ID_Visita", Id);
                    break;
                case "PERSONAL":
                    dataGridView1.DataSource = datos.buscarRegistro("Personal", "Nombre", textBox2.Text, "ID_Personal", Id);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecagarDatos();
        }

        public void RecagarDatos()
        {
            switch (label1.Text)
            {
                case "MEDICAMENTOS Y VACUNAS":
                    dataGridView1.DataSource = connection.GetTable("Medicamentos_Vacunas");
                    break;
                case "PACIENTES":
                    dataGridView1.DataSource = connection.GetTable("Pacientes");
                    break;
                case "CITAS":
                    dataGridView1.DataSource = connection.GetTable("Citas");
                    break;
                case "MATERIAL MEDICO Y EQUIPAMIENTO":
                    dataGridView1.DataSource = connection.GetTable("Material_Medico_Equipamiento");
                    break;
                case "DUEÑOS":
                    dataGridView1.DataSource = connection.GetTable("Duenos");
                    break;
                case "CLIENTES":
                    dataGridView1.DataSource = connection.GetTable("Clientes");
                    break;
                case "ALIMENTOS Y SUPLEMENTOS":
                    dataGridView1.DataSource = connection.GetTable("Alimentos_Suplementos");
                    break;
                case "HISTORIAL MEDICO":
                    dataGridView1.DataSource = connection.GetTable("HistorialMedico");
                    break;
                case "PROVEEDORES":
                    dataGridView1.DataSource = connection.GetTable("Proveedores");
                    break;
                case "PRODUCTOS":
                    dataGridView1.DataSource = connection.GetTable("Productos_Generales");
                    break;
                case "DIAGNOSTICOS":
                    dataGridView1.DataSource = connection.GetTable("Diagnosticos");
                    break;
                case "PAGOS Y FACTURACION":
                    dataGridView1.DataSource = connection.GetTable("Transacciones");
                    break;
                case "DOCUMENTOS Y MATERIAL ADMINISTRATIVO":
                    dataGridView1.DataSource = connection.GetTable("Documentos_Materiales_Administrativos");
                    break;
                case "VISITAS":
                    dataGridView1.DataSource = connection.GetTable("Visitas");
                    break;
                case "PERSONAL":
                    dataGridView1.DataSource = connection.GetTable("Personal");
                    break;
            }
        }
    }
}

