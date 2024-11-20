namespace VetenProyect
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            serviceLabel11 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            serviceImage = new PictureBox();
            button1 = new Button();
            serviceLabel = new Label();
            priceServiceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)serviceImage).BeginInit();
            SuspendLayout();
            // 
            // serviceLabel11
            // 
            serviceLabel11.AutoSize = true;
            serviceLabel11.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceLabel11.ForeColor = SystemColors.ControlLightLight;
            serviceLabel11.Location = new Point(63, 57);
            serviceLabel11.Name = "serviceLabel11";
            serviceLabel11.Size = new Size(163, 38);
            serviceLabel11.TabIndex = 0;
            serviceLabel11.Text = "SERVICIO: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(75, 249);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 27);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(69, 209);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 10;
            label2.Text = "NOMBRE COMPLETO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(75, 316);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "MASCOTA:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 361);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(370, 28);
            comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(75, 447);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 15;
            label4.Text = "FECHAS PROGRAMADAS:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.Location = new Point(75, 490);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(370, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // serviceImage
            // 
            serviceImage.Image = (Image)resources.GetObject("serviceImage.Image");
            serviceImage.Location = new Point(480, 85);
            serviceImage.Name = "serviceImage";
            serviceImage.Size = new Size(417, 527);
            serviceImage.SizeMode = PictureBoxSizeMode.Zoom;
            serviceImage.TabIndex = 17;
            serviceImage.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(75, 575);
            button1.Name = "button1";
            button1.Size = new Size(370, 37);
            button1.TabIndex = 18;
            button1.Text = "continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // serviceLabel
            // 
            serviceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceLabel.ForeColor = Color.Chartreuse;
            serviceLabel.Location = new Point(63, 114);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(380, 69);
            serviceLabel.TabIndex = 19;
            serviceLabel.Text = "SERVICIO EJEMPLO";
            // 
            // priceServiceLabel
            // 
            priceServiceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceServiceLabel.ForeColor = Color.Chartreuse;
            priceServiceLabel.Location = new Point(371, 580);
            priceServiceLabel.Name = "priceServiceLabel";
            priceServiceLabel.Size = new Size(380, 69);
            priceServiceLabel.TabIndex = 21;
            priceServiceLabel.Text = "SERVICIO EJEMPLO";
            priceServiceLabel.Visible = false;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(980, 739);
            Controls.Add(priceServiceLabel);
            Controls.Add(serviceLabel);
            Controls.Add(button1);
            Controls.Add(serviceImage);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(serviceLabel11);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServiceForm";
            Text = "VETEN-Servicios";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)serviceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label serviceLabel11;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        public Label serviceLabel;
        public PictureBox serviceImage;
        public Label priceServiceLabel;
    }
}