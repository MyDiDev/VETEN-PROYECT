using Datos;

namespace VetenProyect
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public string clientName;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Connection conn = new();
            dataGridView1.DataSource = conn.GetCitasRecordatorios(clientName);
            int dateID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            conn.CheckCitaDate(DateTime.Now, dateID);
        }
    }
}
