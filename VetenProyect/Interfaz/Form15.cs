using Logica.Clases.Inventarios;
using System.Security.Cryptography;

namespace VetenProyect
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public Productos producto = new("", "", "", 0.0, 0);    

        private Form activeForm = null;


        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
                return;
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form.Tag;
            form.BringToFront();
            form.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 1re producto
            ProductoForn f7 = new ProductoForn();
            panel1.BringToFront();
            OpenForm(f7);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProductoForn f7 = new ProductoForn();
            f7.Text = "VETEN-Bravecto";
            f7.productLabel.Text = "BRAVECTO";
            f7.infoLabel.Text = "Bravecto es un tratamiento antiparasitario de acción prolongada para perros y gatos, eficaz contra pulgas y varias especies de garrapatas. Está disponible en forma de tabletas masticables para perros y solución tópica (spot-on) para ambos. Su efecto dura hasta 12 semanas, eliminando parásitos y previniendo nuevas infestaciones.";
            f7.priceLabel.Text = producto.getProductoPrice("BRAVECTO");
            f7.productImage.Image = null;
            f7.productImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\Bravecto_500_biovets.png");
            panel1.BringToFront();
            OpenForm(f7);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProductoForn f7 = new ProductoForn();
            f7.Text = "VETEN-Hill's Prescription Diet";
            f7.productLabel.Text = "HILLs PRESCRITION DIET";
            f7.infoLabel.Text = "Hill's Prescription Diet es una línea de alimentos terapéuticos para perros y gatos, formulada para ayudar a manejar condiciones de salud específicas como enfermedades renales, digestivas, urinarias, alergias y control de peso. Desarrollada por veterinarios y nutricionistas, la línea incluye opciones húmedas y secas adaptadas a distintas necesidades, mejorando la calidad de vida de las mascotas a través de la nutrición especializada. ";
            f7.priceLabel.Text = producto.getProductoPrice("HILLs PRESCRITION DIET");
            f7.productImage.Image = null;
            f7.productImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\hills_prescription_die_img.png");
            panel1.BringToFront();
            OpenForm(f7);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ProductoForn f7 = new ProductoForn();
            f7.Text = "VETEN-Seresto Collar Antiparasitario";
            f7.productLabel.Text = "SERESTO COLLAR ANTIPARASITARIO";
            f7.infoLabel.Text = "El collar antiparasitario Seresto es un collar de larga duración para perros y gatos, diseñado para repeler y eliminar pulgas y garrapatas. Proporciona hasta 8 meses de protección continua y es resistente al agua, lo que permite que las mascotas sigan protegidas incluso tras el contacto con agua. Es seguro para usar en cachorros y gatitos a partir de las 7 semanas de edad.";
            f7.priceLabel.Text = producto.getProductoPrice("SERESTO COLLAR ANTIPARASITARIO"); ;
            f7.productImage.Image = null;
            f7.productImage.Image = Image.FromFile("C:\\Users\\Dlsr2\\OneDrive\\Imágenes\\seresto-collares-para-perros-63ea71a3d0d68_g.png");
            panel1.BringToFront();
            OpenForm(f7);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}