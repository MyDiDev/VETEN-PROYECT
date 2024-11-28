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
            double precioUnitario = Convert.ToDouble(unitaryPrice.Text);
            int cantidad = Convert.ToInt32(amount.Text);

            Productos productos = new Productos(Nombre, Descripcion, IdProveedor.Text, precioUnitario, cantidad);
            string result = productos.agregarProducto();

            if (result == "1") { MessageBox.Show("Producto Agregado Correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
            {
                MessageBox.Show($"ERROR: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
