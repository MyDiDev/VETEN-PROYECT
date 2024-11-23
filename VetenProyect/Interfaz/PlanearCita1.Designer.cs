namespace VetenProyect
{
    partial class PlanearCita1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanearCita1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            petDescription = new TextBox();
            label7 = new Label();
            petStateDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            petName = new TextBox();
            label3 = new Label();
            clientName = new TextBox();
            label6 = new Label();
            label8 = new Label();
            reason = new ComboBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(295, 22);
            label1.Name = "label1";
            label1.Size = new Size(295, 50);
            label1.TabIndex = 0;
            label1.Text = "PLANEAR CITA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(309, 111);
            label2.Name = "label2";
            label2.Size = new Size(259, 20);
            label2.TabIndex = 4;
            label2.Text = "DATOS SOBRE El ANIMAL/MASCOTA:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(146, 696);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(609, 47);
            button1.TabIndex = 26;
            button1.Text = "continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(petDescription);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(petStateDescription);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(reason);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(petName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(clientName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 756);
            panel1.TabIndex = 29;
            // 
            // petDescription
            // 
            petDescription.Anchor = AnchorStyles.None;
            petDescription.BackColor = Color.Ivory;
            petDescription.BorderStyle = BorderStyle.FixedSingle;
            petDescription.ForeColor = Color.Black;
            petDescription.Location = new Point(132, 473);
            petDescription.Margin = new Padding(3, 4, 3, 4);
            petDescription.Multiline = true;
            petDescription.Name = "petDescription";
            petDescription.Size = new Size(281, 185);
            petDescription.TabIndex = 36;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(132, 431);
            label7.Name = "label7";
            label7.Size = new Size(187, 20);
            label7.TabIndex = 35;
            label7.Text = "DESCRIBA A SU MASCOTA:";
            // 
            // petStateDescription
            // 
            petStateDescription.Anchor = AnchorStyles.None;
            petStateDescription.BackColor = Color.Ivory;
            petStateDescription.BorderStyle = BorderStyle.FixedSingle;
            petStateDescription.ForeColor = Color.Black;
            petStateDescription.Location = new Point(487, 473);
            petStateDescription.Margin = new Padding(3, 4, 3, 4);
            petStateDescription.Multiline = true;
            petStateDescription.Name = "petStateDescription";
            petStateDescription.Size = new Size(281, 185);
            petStateDescription.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(487, 431);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 33;
            label5.Text = "DESCRIBA EL MOTIVO:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(132, 312);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 31;
            label4.Text = "TIPO DE CITA:";
            // 
            // petName
            // 
            petName.Anchor = AnchorStyles.None;
            petName.BackColor = Color.Ivory;
            petName.BorderStyle = BorderStyle.FixedSingle;
            petName.ForeColor = Color.Black;
            petName.Location = new Point(487, 225);
            petName.Margin = new Padding(3, 4, 3, 4);
            petName.Name = "petName";
            petName.Size = new Size(281, 27);
            petName.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(487, 183);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 29;
            label3.Text = "NOMBRE DE LA MASCOTA:";
            // 
            // clientName
            // 
            clientName.Anchor = AnchorStyles.None;
            clientName.BackColor = Color.Ivory;
            clientName.BorderStyle = BorderStyle.FixedSingle;
            clientName.ForeColor = Color.Black;
            clientName.Location = new Point(132, 225);
            clientName.Margin = new Padding(3, 4, 3, 4);
            clientName.Name = "clientName";
            clientName.Size = new Size(281, 27);
            clientName.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(132, 189);
            label6.Name = "label6";
            label6.Size = new Size(229, 20);
            label6.TabIndex = 27;
            label6.Text = "NOMBRE/NOMBRE DE USUARIO:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(487, 308);
            label8.Name = "label8";
            label8.Size = new Size(182, 20);
            label8.TabIndex = 37;
            label8.Text = "ESTADO DE LA MASCOTA:";
            // 
            // reason
            // 
            reason.BackColor = Color.Ivory;
            reason.FormattingEnabled = true;
            reason.Items.AddRange(new object[] { "Consulta General (Chequeo de salud)", "Vacunación", "Desparacitación", "Emergencias", "Consulta de Dermatología (Problemas de piel)", "Consulta Odontológica", "Chequeo para Esterilización/Castración", "Exámenes de Laboratorio (Análisis de sangre, orina, etc.)", "Consulta de Comportamiento", "Atención Geriátrica", "Cirugía", "Atención de Urgencias Quirúrgicas", "Seguimiento Postoperatorio", "Consulta de Nutrición", "Pruebas de Diagnóstico por Imágenes (Radiografías, Ecografías)" });
            reason.Location = new Point(132, 349);
            reason.Name = "reason";
            reason.Size = new Size(281, 28);
            reason.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Saludable", "Enfermo", "En Recuperación", "Bajo Tratamiento", "En Emergencia", "Convaleciente" });
            comboBox1.Location = new Point(487, 349);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(281, 28);
            comboBox1.TabIndex = 38;
            // 
            // PlanearCita1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(916, 756);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlanearCita1";
            Text = "VETEN-PLANEAR CITA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private TextBox petName;
        private Label label3;
        private TextBox clientName;
        private Label label6;
        private Label label4;
        private TextBox petDescription;
        private Label label7;
        private TextBox petStateDescription;
        private Label label5;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox reason;
    }
}