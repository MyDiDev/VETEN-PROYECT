namespace VetenProyect
{
    partial class RegisterMascot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMascot));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            animalName = new TextBox();
            label3 = new Label();
            animalSpecie = new TextBox();
            label4 = new Label();
            animalType = new TextBox();
            label5 = new Label();
            label6 = new Label();
            animalGender = new ComboBox();
            animalAge = new TextBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(49, 40);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 0;
            label1.Text = "REGISTRA TU MASCOTA";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 582);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // animalName
            // 
            animalName.Anchor = AnchorStyles.None;
            animalName.BackColor = Color.Ivory;
            animalName.BorderStyle = BorderStyle.FixedSingle;
            animalName.ForeColor = Color.Black;
            animalName.Location = new Point(63, 184);
            animalName.Margin = new Padding(3, 4, 3, 4);
            animalName.Name = "animalName";
            animalName.Size = new Size(315, 27);
            animalName.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(63, 148);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 9;
            label3.Text = "NOMBRE COMPLETO DEL ANIMAL:";
            // 
            // animalSpecie
            // 
            animalSpecie.Anchor = AnchorStyles.None;
            animalSpecie.BackColor = Color.Ivory;
            animalSpecie.BorderStyle = BorderStyle.FixedSingle;
            animalSpecie.ForeColor = Color.Black;
            animalSpecie.Location = new Point(63, 286);
            animalSpecie.Margin = new Padding(3, 4, 3, 4);
            animalSpecie.Name = "animalSpecie";
            animalSpecie.Size = new Size(315, 27);
            animalSpecie.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(63, 250);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "ESPECIE:";
            // 
            // animalType
            // 
            animalType.Anchor = AnchorStyles.None;
            animalType.BackColor = Color.Ivory;
            animalType.BorderStyle = BorderStyle.FixedSingle;
            animalType.ForeColor = Color.Black;
            animalType.Location = new Point(63, 487);
            animalType.Margin = new Padding(3, 4, 3, 4);
            animalType.Name = "animalType";
            animalType.Size = new Size(315, 27);
            animalType.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(63, 451);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 13;
            label5.Text = "RAZA:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(63, 553);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 15;
            label6.Text = "SEXO:";
            // 
            // animalGender
            // 
            animalGender.Anchor = AnchorStyles.None;
            animalGender.BackColor = Color.Ivory;
            animalGender.FlatStyle = FlatStyle.Flat;
            animalGender.ForeColor = Color.Black;
            animalGender.FormattingEnabled = true;
            animalGender.Items.AddRange(new object[] { "Femenino", "Masculino" });
            animalGender.Location = new Point(63, 593);
            animalGender.Margin = new Padding(3, 4, 3, 4);
            animalGender.Name = "animalGender";
            animalGender.Size = new Size(315, 28);
            animalGender.TabIndex = 27;
            // 
            // animalAge
            // 
            animalAge.Anchor = AnchorStyles.None;
            animalAge.BackColor = Color.Ivory;
            animalAge.BorderStyle = BorderStyle.FixedSingle;
            animalAge.ForeColor = Color.Black;
            animalAge.Location = new Point(63, 380);
            animalAge.Margin = new Padding(3, 4, 3, 4);
            animalAge.Name = "animalAge";
            animalAge.Size = new Size(315, 27);
            animalAge.TabIndex = 29;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(63, 344);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 28;
            label7.Text = "EDAD:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(73, 681);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(808, 47);
            button1.TabIndex = 32;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegisterMascot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(916, 756);
            Controls.Add(button1);
            Controls.Add(animalAge);
            Controls.Add(label7);
            Controls.Add(animalGender);
            Controls.Add(label6);
            Controls.Add(animalType);
            Controls.Add(label5);
            Controls.Add(animalSpecie);
            Controls.Add(label4);
            Controls.Add(animalName);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterMascot";
            Text = "VETEN-Registrar Mascota";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox animalName;
        private Label label3;
        private TextBox animalSpecie;
        private Label label4;
        private TextBox animalType;
        private Label label5;
        private Label label6;
        private ComboBox animalGender;
        private TextBox animalAge;
        private Label label7;
        private Button button1;
    }
}