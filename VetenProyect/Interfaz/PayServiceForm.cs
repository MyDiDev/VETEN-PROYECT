using Logica.Clases.Registros;
using Logica.Clases.Extra;

namespace VetenProyect
{
    public partial class PayServiceForm : Form
    {
        public PayServiceForm()
        {
            InitializeComponent();
        }

        public string clientName;
        public string petName;
        public decimal Price;
        public DateTime date;

        private void Form9_Load(object sender, EventArgs e)
        {
            switch (serviceLabel.Text)
            {
                case "CONSULTA GENERAL Y DIAGNOSTICO":
                    Price = 2000;
                    break;
                case "CIRUGIA DE ESTERIZALISACION/CASTRACION":
                    Price = 3500;
                    break;
                case "RADIOGRAFIA VETERINARIA":
                    Price = 3000;
                    break;
                case "VACUNACION Y DESPARASITACION":
                    Price = 1500;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cardName.Text) || string.IsNullOrEmpty(dateExpired.Text) ||
                string.IsNullOrEmpty(cardNum.Text) || string.IsNullOrEmpty(cvv.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!masterCheck.Checked && !visaCheck.Checked)
            {
                MessageBox.Show("Seleccione un tipo de tarjeta, mastercard/visa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (masterCheck.Checked && visaCheck.Checked)
            {
                MessageBox.Show("Seleccione solo un tipo de tarjeta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cardType = masterCheck.Checked ? "Mastercard" : "Visa";
            string CardNum = cardNum.Text.Trim();

            if (CardNum.Length != 16)
            {
                MessageBox.Show("Ingrese un numero de tarjeta valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cvv.Text.Length != 3)
            {
                MessageBox.Show("Ingrese un numero de CVV o CVC valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateExpired.Text.Length != 5)
            {
                MessageBox.Show("Ingrese una fecha de expiracion valida, formato: mm/yy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Transacciones transaccion = new(clientName, DateTime.Now, $"Servicio de: {serviceLabel.Text}", cardType, Price, $"Servicio planeado para: {serviceLabel.Text}", "PAGADO");
            CitasRecordatorios citasRecordatorios = new(date, serviceLabel.Text, $"Servicio de: {serviceLabel.Text}", $"Servicio planeado para: {serviceLabel.Text}", "Desconocido");

            string result = citasRecordatorios.agregregarCitaRecordatorio(clientName, petName);
            if (result == "1" && transaccion.agregarTransaccion() == "1")
            {
                MessageBox.Show("Servicio Planeado exitosamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            else
            {
                MessageBox.Show($"{result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
