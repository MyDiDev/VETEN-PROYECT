namespace VetenProyect.InterfazInserccion.Registros
{
    partial class CitasForm
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
            idClient = new TextBox();
            label1 = new Label();
            idPet = new TextBox();
            label2 = new Label();
            IdPersonal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            DatePlanned = new DateTimePicker();
            serviceType = new TextBox();
            label5 = new Label();
            petState = new TextBox();
            label6 = new Label();
            observaciones = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // idClient
            // 
            idClient.Anchor = AnchorStyles.None;
            idClient.Location = new Point(29, 95);
            idClient.Name = "idClient";
            idClient.Size = new Size(298, 27);
            idClient.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 4;
            label1.Text = "ID del Cliente:";
            // 
            // idPet
            // 
            idPet.Anchor = AnchorStyles.None;
            idPet.Location = new Point(405, 95);
            idPet.Name = "idPet";
            idPet.Size = new Size(298, 27);
            idPet.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(405, 57);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "ID de la Mascota:";
            // 
            // IdPersonal
            // 
            IdPersonal.Anchor = AnchorStyles.None;
            IdPersonal.Location = new Point(29, 219);
            IdPersonal.Name = "IdPersonal";
            IdPersonal.Size = new Size(298, 27);
            IdPersonal.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(29, 181);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "ID del Personal:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(405, 181);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 10;
            label4.Text = "Fecha Planeada:";
            // 
            // DatePlanned
            // 
            DatePlanned.Anchor = AnchorStyles.None;
            DatePlanned.Location = new Point(405, 217);
            DatePlanned.Name = "DatePlanned";
            DatePlanned.Size = new Size(298, 27);
            DatePlanned.TabIndex = 11;
            // 
            // serviceType
            // 
            serviceType.Anchor = AnchorStyles.None;
            serviceType.Location = new Point(29, 344);
            serviceType.Name = "serviceType";
            serviceType.Size = new Size(298, 27);
            serviceType.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(29, 306);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "Tipo del Servicio:";
            // 
            // petState
            // 
            petState.Anchor = AnchorStyles.None;
            petState.Location = new Point(405, 344);
            petState.Name = "petState";
            petState.Size = new Size(298, 27);
            petState.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(405, 306);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 14;
            label6.Text = "Estado de la Mascota:";
            // 
            // observaciones
            // 
            observaciones.Anchor = AnchorStyles.None;
            observaciones.Location = new Point(29, 436);
            observaciones.Multiline = true;
            observaciones.Name = "observaciones";
            observaciones.Size = new Size(674, 113);
            observaciones.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(309, 402);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 16;
            label7.Text = "Observaciones:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(29, 588);
            button1.Name = "button1";
            button1.Size = new Size(674, 52);
            button1.TabIndex = 18;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CitasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 652);
            Controls.Add(button1);
            Controls.Add(observaciones);
            Controls.Add(label7);
            Controls.Add(petState);
            Controls.Add(label6);
            Controls.Add(serviceType);
            Controls.Add(label5);
            Controls.Add(DatePlanned);
            Controls.Add(label4);
            Controls.Add(IdPersonal);
            Controls.Add(label3);
            Controls.Add(idPet);
            Controls.Add(label2);
            Controls.Add(idClient);
            Controls.Add(label1);
            Name = "CitasForm";
            Text = "CitasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idClient;
        private Label label1;
        private TextBox idPet;
        private Label label2;
        private TextBox IdPersonal;
        private Label label3;
        private Label label4;
        private DateTimePicker DatePlanned;
        private TextBox serviceType;
        private Label label5;
        private TextBox petState;
        private Label label6;
        private TextBox observaciones;
        private Label label7;
        private Button button1;
    }
}