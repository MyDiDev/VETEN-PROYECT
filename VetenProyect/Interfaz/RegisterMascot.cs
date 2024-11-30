using Logica.Clases.Extra;
using System.Diagnostics.CodeAnalysis;

namespace VetenProyect
{
    public partial class RegisterMascot : Form
    {
        public RegisterMascot()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public string clientName;

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = -1;

            if (string.IsNullOrEmpty(animalName.Text) || string.IsNullOrEmpty(animalSpecie.Text)
                || string.IsNullOrEmpty(animalAge.Text) || string.IsNullOrEmpty(animalType.Text) || string.IsNullOrEmpty(animalGender.Text)) {
                MessageBox.Show("Llene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Age = Convert.ToInt32(animalAge.Text);
                if (Age > 80)
                {
                    MessageBox.Show("Ingrese una edad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }catch (FormatException)
            {
                MessageBox.Show("Ingrese una edad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mascota pet = new(animalName.Text, animalSpecie.Text, animalType.Text, Age, animalGender.Text);
            string result = pet.agregarMascota(clientName);
            if (result == "1") { 
                MessageBox.Show("Mascota agregada exitosamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            else
            {
                MessageBox.Show($"Error: {result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }
}
