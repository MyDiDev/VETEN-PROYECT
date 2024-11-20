namespace VetenProyect.InterfazInserccion
{
    partial class AlimentosSuplementosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimentosSuplementosForm));
            amount = new TextBox();
            label6 = new Label();
            unitaryPrice = new TextBox();
            label5 = new Label();
            description = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.None;
            amount.Location = new Point(431, 103);
            amount.Name = "amount";
            amount.Size = new Size(298, 27);
            amount.TabIndex = 29;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(431, 65);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 28;
            label6.Text = "Cantidad:";
            // 
            // unitaryPrice
            // 
            unitaryPrice.Anchor = AnchorStyles.None;
            unitaryPrice.Location = new Point(431, 279);
            unitaryPrice.Name = "unitaryPrice";
            unitaryPrice.Size = new Size(298, 27);
            unitaryPrice.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(431, 245);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 26;
            label5.Text = "Precio Unitario:";
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.Location = new Point(72, 232);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(298, 148);
            description.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(72, 194);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 24;
            label2.Text = "Descripcion:";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(72, 103);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(72, 65);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(72, 425);
            button1.Name = "button1";
            button1.Size = new Size(657, 49);
            button1.TabIndex = 30;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AlimentosSuplementosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button1);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(unitaryPrice);
            Controls.Add(label5);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlimentosSuplementosForm";
            Text = "VETEN-Agregar Alimentos/Vacunas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox amount;
        private Label label6;
        private TextBox unitaryPrice;
        private Label label5;
        private TextBox description;
        private Label label2;
        private TextBox name;
        private Label label1;
        private Button button1;
    }
}