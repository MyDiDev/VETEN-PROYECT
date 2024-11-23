namespace VetenProyect.InterfazInserccion.Historiales
{
    partial class PacienteForm
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
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            specie = new TextBox();
            label3 = new Label();
            race = new TextBox();
            label4 = new Label();
            label5 = new Label();
            idClient = new TextBox();
            addBtn = new Button();
            label6 = new Label();
            age = new TextBox();
            gender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Paciente:";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(42, 82);
            name.Name = "name";
            name.Size = new Size(238, 27);
            name.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(42, 174);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 5;
            label2.Text = "Especie del Paciente:";
            // 
            // specie
            // 
            specie.Anchor = AnchorStyles.None;
            specie.Location = new Point(42, 209);
            specie.Name = "specie";
            specie.Size = new Size(238, 27);
            specie.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(42, 285);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Raza:";
            // 
            // race
            // 
            race.Anchor = AnchorStyles.None;
            race.Location = new Point(42, 320);
            race.Name = "race";
            race.Size = new Size(238, 27);
            race.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(376, 47);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(376, 285);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 11;
            label5.Text = "ID del Cliente:";
            // 
            // idClient
            // 
            idClient.Anchor = AnchorStyles.None;
            idClient.Location = new Point(376, 320);
            idClient.Name = "idClient";
            idClient.Size = new Size(238, 27);
            idClient.TabIndex = 10;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(42, 398);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(572, 49);
            addBtn.TabIndex = 12;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(376, 174);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 14;
            label6.Text = "Edad del Paciente:";
            // 
            // age
            // 
            age.Anchor = AnchorStyles.None;
            age.Location = new Point(376, 209);
            age.Name = "age";
            age.Size = new Size(238, 27);
            age.TabIndex = 13;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Varon", "Hembra" });
            gender.Location = new Point(376, 82);
            gender.Name = "gender";
            gender.Size = new Size(238, 28);
            gender.TabIndex = 15;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 470);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(age);
            Controls.Add(addBtn);
            Controls.Add(label5);
            Controls.Add(idClient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(race);
            Controls.Add(label2);
            Controls.Add(specie);
            Controls.Add(label1);
            Controls.Add(name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PacienteForm";
            Text = "PacienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private TextBox specie;
        private Label label3;
        private TextBox race;
        private Label label4;
        private Label label5;
        private TextBox idClient;
        private Button addBtn;
        private Label label6;
        private TextBox age;
        private ComboBox gender;
    }
}