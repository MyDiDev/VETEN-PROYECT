namespace VetenProyect.InterfazInserccion.Registros
{
    partial class TransaccionesForm
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
            description = new TextBox();
            label6 = new Label();
            label5 = new Label();
            DatePlanned = new DateTimePicker();
            label4 = new Label();
            amount = new TextBox();
            label3 = new Label();
            type = new TextBox();
            label2 = new Label();
            clientName = new TextBox();
            label1 = new Label();
            Paymethod = new ComboBox();
            label7 = new Label();
            state = new TextBox();
            add = new Button();
            SuspendLayout();
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.Location = new Point(411, 363);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(298, 91);
            description.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(411, 325);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 26;
            label6.Text = "Descripcion (Opcional):";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(35, 308);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 24;
            label5.Text = "Monto Cobrado:";
            // 
            // DatePlanned
            // 
            DatePlanned.Anchor = AnchorStyles.None;
            DatePlanned.Location = new Point(411, 219);
            DatePlanned.Name = "DatePlanned";
            DatePlanned.Size = new Size(298, 27);
            DatePlanned.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(411, 183);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 22;
            label4.Text = "Fecha en la que se Realizo:";
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.None;
            amount.Location = new Point(35, 346);
            amount.Name = "amount";
            amount.Size = new Size(298, 27);
            amount.TabIndex = 21;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(35, 183);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 20;
            label3.Text = "Metodo de Pago:";
            // 
            // type
            // 
            type.Anchor = AnchorStyles.None;
            type.Location = new Point(411, 97);
            type.Name = "type";
            type.Size = new Size(298, 27);
            type.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(411, 59);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 18;
            label2.Text = "Tipo de Transaccion:";
            // 
            // clientName
            // 
            clientName.Anchor = AnchorStyles.None;
            clientName.Location = new Point(35, 97);
            clientName.Name = "clientName";
            clientName.Size = new Size(298, 27);
            clientName.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(35, 59);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombre del Cliente:";
            // 
            // Paymethod
            // 
            Paymethod.Anchor = AnchorStyles.None;
            Paymethod.FormattingEnabled = true;
            Paymethod.Items.AddRange(new object[] { "Visa", "Mastercard" });
            Paymethod.Location = new Point(35, 221);
            Paymethod.Name = "Paymethod";
            Paymethod.Size = new Size(298, 28);
            Paymethod.TabIndex = 29;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(35, 434);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 31;
            label7.Text = "Estado:";
            // 
            // state
            // 
            state.Anchor = AnchorStyles.None;
            state.Location = new Point(35, 472);
            state.Name = "state";
            state.Size = new Size(298, 27);
            state.TabIndex = 30;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.None;
            add.Location = new Point(35, 572);
            add.Name = "add";
            add.Size = new Size(674, 40);
            add.TabIndex = 32;
            add.Text = "Agregar";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // TransaccionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 659);
            Controls.Add(add);
            Controls.Add(label7);
            Controls.Add(state);
            Controls.Add(Paymethod);
            Controls.Add(description);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DatePlanned);
            Controls.Add(label4);
            Controls.Add(amount);
            Controls.Add(label3);
            Controls.Add(type);
            Controls.Add(label2);
            Controls.Add(clientName);
            Controls.Add(label1);
            Name = "TransaccionesForm";
            Text = "Agregar Transaccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private Label label6;
        private TextBox serviceType;
        private Label label5;
        private DateTimePicker DatePlanned;
        private Label label4;
        private TextBox amount;
        private Label label3;
        private TextBox type;
        private Label label2;
        private TextBox clientName;
        private Label label1;
        private ComboBox Paymethod;
        private Label label7;
        private TextBox state;
        private Button add;
    }
}