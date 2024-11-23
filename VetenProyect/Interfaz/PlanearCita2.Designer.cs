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
            label2 = new Label();
            date = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            doctors = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(295, 50);
            label1.TabIndex = 4;
            label1.Text = "PLANEAR CITA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(23, 245);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 17;
            label2.Text = "FECHA PARA LA CITA:";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.None;
            date.CalendarMonthBackground = Color.Ivory;
            date.Location = new Point(21, 289);
            date.Margin = new Padding(3, 4, 3, 4);
            date.Name = "date";
            date.Size = new Size(299, 27);
            date.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 99);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 545);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(146, 696);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(609, 47);
            button1.TabIndex = 25;
            button1.Text = "continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // doctors
            // 
            doctors.Anchor = AnchorStyles.None;
            doctors.BackColor = Color.Ivory;
            doctors.FlatStyle = FlatStyle.Flat;
            doctors.FormattingEnabled = true;
            doctors.Location = new Point(23, 476);
            doctors.Margin = new Padding(3, 4, 3, 4);
            doctors.Name = "doctors";
            doctors.Size = new Size(297, 28);
            doctors.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(23, 436);
            label3.Name = "label3";
            label3.Size = new Size(292, 20);
            label3.TabIndex = 21;
            label3.Text = "ELIGA EL DOCTOR /A DE SU PREFERENCIA:";
            // 
            // panel1
            // 
            panel1.Controls.Add(date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(doctors);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 756);
            panel1.TabIndex = 27;
            // 
            // PlanearCita2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 756);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlanearCita2";
            Text = "VETEN-PLANEAR CITA";
            Load += PlanearCita2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private DateTimePicker date;
        private PictureBox pictureBox1;
        private Button button1;
        private ComboBox doctors;
        private Label label3;
        private Panel panel1;
    }
}