using Logica.Clases.Extra;
using Logica.Clases.Registros;

namespace VetenProyect
{
    public partial class PlanearCita3 : Form
    {
        public PlanearCita3()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public string TipoCita;
        public string clientName;
        public string petName;
        public string petState;
        public string petDescription;
        public string reasonDescription;
        public DateTime appointmentDate;
        public string doctor;
        public decimal Price;

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

            CitasRecordatorios citasRecordatorios = new(appointmentDate, TipoCita, reasonDescription, petDescription, petState);
            Transacciones transaccion = new(clientName, DateTime.Now, $"Cita de: {TipoCita}", cardType, Price, $"Cita planeada sobre: {TipoCita}", "PAGADO");

            string result = citasRecordatorios.agregregarCitaRecordatorio(clientName, petName);
            if (result  == "1" && transaccion.agregarTransaccion() == "1")
            {
                MessageBox.Show("Cita Planeada exitosamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            else
            {
                MessageBox.Show($"{result}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PlanearCita3_Load(object sender, EventArgs e)
        {
            priceLabel.Text = Convert.ToString(Price) + " $RDS";
        }
    }
}
