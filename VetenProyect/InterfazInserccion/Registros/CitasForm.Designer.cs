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
            clientName = new TextBox();
            label1 = new Label();
            petName = new TextBox();
            label2 = new Label();
            personalName = new TextBox();
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
            // clientName
            // 
            clientName.Anchor = AnchorStyles.None;
            clientName.Location = new Point(29, 95);
            clientName.Name = "clientName";
            clientName.Size = new Size(298, 27);
            clientName.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre del Cliente:";
            // 
            // petName
            // 
            petName.Anchor = AnchorStyles.None;
            petName.Location = new Point(405, 95);
            petName.Name = "petName";
            petName.Size = new Size(298, 27);
            petName.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(405, 57);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre de la Mascota:";
            // 
            // personalName
            // 
            personalName.Anchor = AnchorStyles.None;
            personalName.Location = new Point(29, 219);
            personalName.Name = "personalName";
            personalName.Size = new Size(298, 27);
            personalName.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(29, 181);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre del Personal:";
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
            Controls.Add(personalName);
            Controls.Add(label3);
            Controls.Add(petName);
            Controls.Add(label2);
            Controls.Add(clientName);
            Controls.Add(label1);
            Name = "CitasForm";
            Text = "CitasForm";
            Load += CitasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientName;
        private Label label1;
        private TextBox petName;
        private Label label2;
        private TextBox personalName;
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