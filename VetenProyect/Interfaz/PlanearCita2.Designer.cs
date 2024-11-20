namespace VetenProyect
{
    partial class PlanearCita2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanearCita2));
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            appointmentReason = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            appointmentDoctor = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(37, 85);
            label1.Name = "label1";
            label1.Size = new Size(295, 50);
            label1.TabIndex = 4;
            label1.Text = "PLANEAR CITA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(50, 177);
            label6.Name = "label6";
            label6.Size = new Size(173, 20);
            label6.TabIndex = 15;
            label6.Text = "SELECCIONE EL MOTIVO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(52, 300);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 17;
            label2.Text = "FECHA Y HORA PARA LA CITA:";
            // 
            // appointmentReason
            // 
            appointmentReason.BackColor = Color.Ivory;
            appointmentReason.FlatStyle = FlatStyle.Flat;
            appointmentReason.FormattingEnabled = true;
            appointmentReason.Items.AddRange(new object[] { "Chequeo anual de salud", "Vacunación", "Desparasitación interna y externa", "Esterilización o castración", "Revisión dental", "Tratamiento de infecciones", "Problemas digestivos (vómito, diarrea)", "Lesiones o accidentes", "Problemas de piel o pelaje (picazón, pérdida de pelo)", "Tos o dificultad para respirar", "Cambios en el apetito o peso", "Dolor o cojera", "Revisiones geriátricas (mascotas mayores)", "Control de peso", "Problemas de comportamiento", "Embarazo o asistencia en el parto", "Seguimiento de enfermedades crónicas (diabetes, problemas renales)", "Diagnóstico de tumores o bultos", "Pruebas preoperatorias o postoperatorias", "Asesoramiento nutricional." });
            appointmentReason.Location = new Point(52, 225);
            appointmentReason.Margin = new Padding(3, 4, 3, 4);
            appointmentReason.Name = "appointmentReason";
            appointmentReason.Size = new Size(297, 28);
            appointmentReason.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Ivory;
            dateTimePicker1.Location = new Point(50, 344);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 101);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 545);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(50, 579);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(297, 52);
            button1.TabIndex = 25;
            button1.Text = "continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // appointmentDoctor
            // 
            appointmentDoctor.BackColor = Color.Ivory;
            appointmentDoctor.FlatStyle = FlatStyle.Flat;
            appointmentDoctor.FormattingEnabled = true;
            appointmentDoctor.Location = new Point(52, 465);
            appointmentDoctor.Margin = new Padding(3, 4, 3, 4);
            appointmentDoctor.Name = "appointmentDoctor";
            appointmentDoctor.Size = new Size(297, 28);
            appointmentDoctor.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(52, 425);
            label3.Name = "label3";
            label3.Size = new Size(292, 20);
            label3.TabIndex = 21;
            label3.Text = "ELIGA EL DOCTOR /A DE SU PREFERENCIA:";
            // 
            // PlanearCita2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 694);
            Controls.Add(appointmentDoctor);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(appointmentReason);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlanearCita2";
            Text = "VETEN-PLANEAR CITA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label6;
        private Label label2;
        private ComboBox appointmentReason;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox appointmentDoctor;
        private Label label3;
    }
}