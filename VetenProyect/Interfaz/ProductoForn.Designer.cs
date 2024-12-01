namespace VetenProyect
{
    partial class ProductoForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoForn));
            productImage = new PictureBox();
            productLabel = new Label();
            infoLabel = new Label();
            button1 = new Button();
            label3 = new Label();
            priceLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productImage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // productImage
            // 
            productImage.Anchor = AnchorStyles.None;
            productImage.BackColor = Color.FromArgb(82, 110, 72);
            productImage.Image = (Image)resources.GetObject("productImage.Image");
            productImage.Location = new Point(475, 115);
            productImage.Margin = new Padding(3, 4, 3, 4);
            productImage.Name = "productImage";
            productImage.Size = new Size(476, 491);
            productImage.SizeMode = PictureBoxSizeMode.Zoom;
            productImage.TabIndex = 4;
            productImage.TabStop = false;
            // 
            // productLabel
            // 
            productLabel.Anchor = AnchorStyles.None;
            productLabel.BackColor = Color.FromArgb(82, 110, 72);
            productLabel.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productLabel.ForeColor = SystemColors.ControlLightLight;
            productLabel.Location = new Point(60, 154);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(383, 31);
            productLabel.TabIndex = 5;
            productLabel.Text = "ROYAL CANIN, VETENARY DIET";
            // 
            // infoLabel
            // 
            infoLabel.Anchor = AnchorStyles.None;
            infoLabel.BackColor = Color.FromArgb(82, 110, 72);
            infoLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoLabel.ForeColor = SystemColors.ControlLightLight;
            infoLabel.Location = new Point(62, 226);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(383, 282);
            infoLabel.TabIndex = 7;
            infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(62, 592);
            button1.Name = "button1";
            button1.Size = new Size(325, 37);
            button1.TabIndex = 8;
            button1.Text = "comprar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(82, 110, 72);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(60, 508);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 9;
            label3.Text = "PRECIO:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.BackColor = Color.FromArgb(82, 110, 72);
            priceLabel.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = Color.LawnGreen;
            priceLabel.Location = new Point(150, 508);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(130, 31);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "1500RD$";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 110, 72);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 739);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(productImage);
            panel2.Controls.Add(productLabel);
            panel2.Controls.Add(infoLabel);
            panel2.Controls.Add(priceLabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 739);
            panel2.TabIndex = 0;
            // 
            // ProductoForn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 168, 66);
            ClientSize = new Size(980, 739);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductoForn";
            Text = "VETEN-Royal Canin";
            ((System.ComponentModel.ISupportInitialize)productImage).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label3;
        public PictureBox productImage;
        public Label productLabel;
        public Label infoLabel;
        public Label priceLabel;
        private Panel panel1;
        private Panel panel2;
    }
}