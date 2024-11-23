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

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(priceLabel.Text);
            if(string.IsNullOrEmpty(cardName.Text) || string.IsNullOrEmpty(dateExpired.Text) ||
                string.IsNullOrEmpty(cardNum.Text) || string.IsNullOrEmpty(cvv.Text))
            {
                MessageBox.Show("LLene el formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

            CitasRecordatorios citasRecordatorios = new(appointmentDate, TipoCita, 1, 1, reasonDescription, petDescription, petState);
            Transacciones transaccion = new(1, DateTime.Now, $"Cita para: {TipoCita}", "mastercard", price, $"Cita planeada para: {TipoCita}", "PAGADO");
            
        }
    }
}
