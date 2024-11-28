namespace VetenProyect.InterfazInserccion.Inventarios
{
    partial class AddProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductosForm));
            name = new TextBox();
            label1 = new Label();
            description = new TextBox();
            label2 = new Label();
            IdProveedor = new TextBox();
            label3 = new Label();
            unitaryPrice = new TextBox();
            label4 = new Label();
            amount = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(115, 97);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(115, 59);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Producto:";
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.Location = new Point(115, 229);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(298, 100);
            description.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(115, 188);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion del Producto:";
            // 
            // IdProveedor
            // 
            IdProveedor.Anchor = AnchorStyles.None;
            IdProveedor.Location = new Point(115, 421);
            IdProveedor.Name = "IdProveedor";
            IdProveedor.Size = new Size(298, 27);
            IdProveedor.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(115, 383);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre del Proveedor:";
            // 
            // unitaryPrice
            // 
            unitaryPrice.Anchor = AnchorStyles.None;
            unitaryPrice.Location = new Point(115, 526);
            unitaryPrice.Name = "unitaryPrice";
            unitaryPrice.Size = new Size(298, 27);
            unitaryPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(115, 488);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio Unitario:";
            // 
            // amount
            // 
            amount.Anchor = AnchorStyles.None;
            amount.Location = new Point(115, 652);
            amount.Name = "amount";
            amount.Size = new Size(298, 27);
            amount.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(115, 614);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(115, 723);
            button1.Name = "button1";
            button1.Size = new Size(298, 49);
            button1.TabIndex = 35;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 803);
            Controls.Add(button1);
            Controls.Add(amount);
            Controls.Add(label5);
            Controls.Add(unitaryPrice);
            Controls.Add(label4);
            Controls.Add(IdProveedor);
            Controls.Add(label3);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductosForm";
            Text = "VETEN-Agregar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label1;
        private TextBox description;
        private Label label2;
        private TextBox IdProveedor;
        private Label label3;
        private TextBox unitaryPrice;
        private Label label4;
        private TextBox amount;
        private Label label5;
        private Button button1;
    }
}