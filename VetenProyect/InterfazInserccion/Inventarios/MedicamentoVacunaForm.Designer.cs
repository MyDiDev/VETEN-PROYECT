namespace VetenProyect.InterfazInserccion
{
    partial class MedicamentoVacunaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentoVacunaForm));
            label1 = new Label();
            name = new TextBox();
            description = new TextBox();
            label2 = new Label();
            lote = new TextBox();
            label3 = new Label();
            label4 = new Label();
            recommendDosis = new TextBox();
            label5 = new Label();
            amount = new TextBox();
            label6 = new Label();
            unitaryPrice = new TextBox();
            label7 = new Label();
            button1 = new Button();
            expiredDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(104, 54);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(104, 92);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 1;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.Location = new Point(104, 309);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(298, 106);
            description.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(104, 275);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripcion:";
            // 
            // lote
            // 
            lote.Anchor = AnchorStyles.None;
            lote.Location = new Point(104, 213);
            lote.Name = "lote";
            lote.Size = new Size(298, 27);
            lote.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(104, 175);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Lote:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(355, 454);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Caducidad:";
            label4.Click += label4_Click;
            // 
            // recommendDosis
            // 
            recommendDosis.Anchor = AnchorStyles.None;
            recommendDosis.Location = new Point(477, 92);
            recommendDosis.Name = "recommendDosis";
            recommendDosis.Size = new Size(298, 27);
            recommendDosis.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(477, 54);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 8;
            label5.Text = "Dosis Recomendada:";
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.None;
            amount.Location = new Point(477, 213);
            amount.Name = "amount";
            amount.Size = new Size(298, 27);
            amount.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(477, 175);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Cantidad:";
            // 
            // unitaryPrice
            // 
            unitaryPrice.Anchor = AnchorStyles.None;
            unitaryPrice.Location = new Point(477, 333);
            unitaryPrice.Name = "unitaryPrice";
            unitaryPrice.Size = new Size(298, 27);
            unitaryPrice.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(477, 295);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 12;
            label7.Text = "Precio Unitario:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(103, 570);
            button1.Name = "button1";
            button1.Size = new Size(671, 49);
            button1.TabIndex = 14;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // expiredDate
            // 
            expiredDate.Anchor = AnchorStyles.None;
            expiredDate.Location = new Point(310, 497);
            expiredDate.Name = "expiredDate";
            expiredDate.Size = new Size(250, 27);
            expiredDate.TabIndex = 15;
            expiredDate.ValueChanged += expiredDate_ValueChanged;
            // 
            // MedicamentoVacunaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 645);
            Controls.Add(expiredDate);
            Controls.Add(button1);
            Controls.Add(unitaryPrice);
            Controls.Add(label7);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(recommendDosis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lote);
            Controls.Add(label3);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MedicamentoVacunaForm";
            Text = "VETEN-Agregar Medicamento/Vacuna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox description;
        private Label label2;
        private TextBox lote;
        private Label label3;
        private Label label4;
        private TextBox recommendDosis;
        private Label label5;
        private TextBox amount;
        private Label label6;
        private TextBox unitaryPrice;
        private Label label7;
        private Button button1;
        private DateTimePicker expiredDate;
    }
}