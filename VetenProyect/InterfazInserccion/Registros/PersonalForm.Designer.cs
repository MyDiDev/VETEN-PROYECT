namespace VetenProyect.InterfazInserccion.Registros
{
    partial class PersonalForm
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
            email = new TextBox();
            label5 = new Label();
            mail = new TextBox();
            cargo = new Label();
            phone = new TextBox();
            label3 = new Label();
            HorarioTrabajo = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            Certifications = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Location = new Point(441, 251);
            email.Name = "email";
            email.Size = new Size(298, 27);
            email.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(441, 213);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 20;
            label5.Text = "Correo Electronico:";
            // 
            // mail
            // 
            mail.Anchor = AnchorStyles.None;
            mail.Location = new Point(441, 120);
            mail.Name = "mail";
            mail.Size = new Size(298, 27);
            mail.TabIndex = 19;
            // 
            // cargo
            // 
            cargo.AutoSize = true;
            cargo.Location = new Point(441, 82);
            cargo.Name = "cargo";
            cargo.Size = new Size(52, 20);
            cargo.TabIndex = 18;
            cargo.Text = "Cargo:";
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.None;
            phone.Location = new Point(66, 262);
            phone.Name = "phone";
            phone.Size = new Size(298, 27);
            phone.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(66, 224);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 16;
            label3.Text = "Telefono:";
            // 
            // HorarioTrabajo
            // 
            HorarioTrabajo.Anchor = AnchorStyles.None;
            HorarioTrabajo.Location = new Point(66, 433);
            HorarioTrabajo.Name = "HorarioTrabajo";
            HorarioTrabajo.Size = new Size(298, 27);
            HorarioTrabajo.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(66, 395);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 14;
            label2.Text = "Horario de Trabajo:";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(66, 120);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(66, 82);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // Certifications
            // 
            Certifications.Anchor = AnchorStyles.None;
            Certifications.Location = new Point(441, 395);
            Certifications.Multiline = true;
            Certifications.Name = "Certifications";
            Certifications.Size = new Size(298, 131);
            Certifications.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(441, 357);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 22;
            label4.Text = "Certificaciones:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(66, 576);
            button1.Name = "button1";
            button1.Size = new Size(673, 54);
            button1.TabIndex = 24;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 657);
            Controls.Add(button1);
            Controls.Add(Certifications);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(cargo);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(HorarioTrabajo);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Personal";
            Text = "Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Label label5;
        private TextBox mail;
        private Label cargo;
        private TextBox phone;
        private Label label3;
        private TextBox HorarioTrabajo;
        private Label label2;
        private TextBox name;
        private Label label1;
        private TextBox Certifications;
        private Label label4;
        private Button button1;
    }
}