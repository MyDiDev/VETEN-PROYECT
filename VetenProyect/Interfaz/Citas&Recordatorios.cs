using Datos;

namespace VetenProyect
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Connection conn = new();
            dataGridView1.DataSource = conn.GetTable("Citas_Recordatorios");
            conn.CheckCitaDate(DateTime.Now, (int)dataGridView1.Rows[0].Cells[0].Value);
        }
    }
}
