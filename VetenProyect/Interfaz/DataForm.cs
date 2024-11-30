using Datos;

namespace VetenProyect
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            ShowDataForm f11 = new ShowDataForm();
            f11.label1.Text = btn1.Text;
            Connection connection = new Connection();


            switch (f11.label1.Text)
            {
                case "MEDICAMENTOS Y VACUNAS":
                    f11.dataGridView1.DataSource = connection.GetTable("Medicamentos_Vacunas");
                    break;
                case "PACIENTES":
                    f11.dataGridView1.DataSource = connection.GetTable("Pacientes");
                    break;
                case "CITAS":
                    f11.dataGridView1.DataSource = connection.GetTable("Citas");
                    break;
            }

            f11.ShowDialog();

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            ShowDataForm f11 = new ShowDataForm();
            f11.label1.Text = btn2.Text;
            Connection connection = new Connection();


            switch (f11.label1.Text)
            {
                case "MATERIAL MEDICO Y EQUIPAMIENTO":
                    f11.dataGridView1.DataSource = connection.GetTable("Material_Medico_Equipamiento");
                    break;
                case "CLIENTES":
                    f11.dataGridView1.DataSource = connection.GetTable("Clientes");
                    break;
                case "CITAS & RECORDATORIOS":
                    f11.dataGridView1.DataSource = connection.GetTable("Citas_Recordatorios");
                    break;
            }

            f11.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowDataForm f11 = new ShowDataForm();
            f11.label1.Text = btn3.Text;
            Connection connection = new Connection();


            switch (f11.label1.Text)
            {
                case "ALIMENTOS Y SUPLEMENTOS":
                    f11.dataGridView1.DataSource = connection.GetTable("Alimentos_Suplementos");
                    break;
                case "HISTORIAL MEDICO":
                    f11.dataGridView1.DataSource = connection.GetTable("HistorialMedico");
                    break;
                case "PROVEEDORES":
                    f11.dataGridView1.DataSource = connection.GetTable("Proveedores");
                    break;

            }
            f11.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowDataForm f11 = new ShowDataForm();
            f11.label1.Text = btn5.Text;
            Connection connection = new Connection();

            switch (f11.label1.Text)
            {
                case "PRODUCTOS":
                    f11.dataGridView1.DataSource =  connection.GetTable("Productos_Generales");
                    break;
                case "DIAGNOSTICOS":
                    f11.dataGridView1.DataSource =  connection.GetTable("Diagnosticos");
                    break;
                case "PAGOS Y FACTURACION":
                    f11.dataGridView1.DataSource =  connection.GetTable("Transacciones");
                    break;
            }

            
            f11.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowDataForm f11 = new ShowDataForm();
            f11.label1.Text = btn4.Text;
            Connection connection = new Connection();

            switch (f11.label1.Text)
            {
                case "DOCUMENTOS Y MATERIAL ADMINISTRATIVO":
                    f11.dataGridView1.DataSource = connection.GetTable("Documentos_Materiales_Administrativos");
                    break;
                case "VISITAS":
                    f11.dataGridView1.DataSource = connection.GetTable("Visitas");
                    break;
                case "PERSONAL":
                    f11.dataGridView1.DataSource = connection.GetTable("Personal");
                    break;
            }

            f11.ShowDialog();
        }
    }
}
