namespace VetenProyect
{
    partial class PayServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayServiceForm));
            label1 = new Label();
            serviceLabel = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            visaCheck = new CheckBox();
            masterCheck = new CheckBox();
            label2 = new Label();
            label7 = new Label();
            dateExpired = new TextBox();
            label5 = new Label();
            cvv = new TextBox();
            label4 = new Label();
            cardNum = new TextBox();
            label3 = new Label();
            cardName = new TextBox();
            label6 = new Label();
            servicePriceLabel = new Label();
            label9 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(410, 60);
            label1.TabIndex = 0;
            label1.Text = "PAGAR SERVICIO:";
            // 
            // serviceLabel
            // 
            serviceLabel.Anchor = AnchorStyles.None;
            serviceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceLabel.ForeColor = Color.Chartreuse;
            serviceLabel.Location = new Point(338, 74);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(280, 66);
            serviceLabel.TabIndex = 20;
            serviceLabel.Text = "SERVICIO EJEMPLO";
            serviceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(326, 212);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(538, 212);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // visaCheck
            // 
            visaCheck.Anchor = AnchorStyles.None;
            visaCheck.AutoSize = true;
            visaCheck.Cursor = Cursors.Hand;
            visaCheck.ForeColor = SystemColors.ControlLightLight;
            visaCheck.Location = new Point(538, 298);
            visaCheck.Margin = new Padding(3, 4, 3, 4);
            visaCheck.Name = "visaCheck";
            visaCheck.Size = new Size(62, 24);
            visaCheck.TabIndex = 34;
            visaCheck.Text = "VISA";
            visaCheck.UseVisualStyleBackColor = true;
            // 
            // masterCheck
            // 
            masterCheck.Anchor = AnchorStyles.None;
            masterCheck.AutoSize = true;
            masterCheck.Cursor = Cursors.Hand;
            masterCheck.ForeColor = SystemColors.ControlLightLight;
            masterCheck.Location = new Point(326, 298);
            masterCheck.Margin = new Padding(3, 4, 3, 4);
            masterCheck.Name = "masterCheck";
            masterCheck.Size = new Size(126, 24);
            masterCheck.TabIndex = 33;
            masterCheck.Text = "MASTERCARD";
            masterCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(383, 153);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 32;
            label2.Text = "ELIGE EL TIPO DE TARJETA:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(538, 488);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 45;
            label7.Text = "(CVV O CVC):";
            // 
            // dateExpired
            // 
            dateExpired.Anchor = AnchorStyles.None;
            dateExpired.BackColor = Color.Ivory;
            dateExpired.BorderStyle = BorderStyle.FixedSingle;
            dateExpired.Location = new Point(538, 390);
            dateExpired.Margin = new Padding(3, 4, 3, 4);
            dateExpired.Name = "dateExpired";
            dateExpired.Size = new Size(234, 27);
            dateExpired.TabIndex = 44;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(538, 354);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 43;
            label5.Text = "FECHA DE EXPIRACION:";
            // 
            // cvv
            // 
            cvv.Anchor = AnchorStyles.None;
            cvv.BackColor = Color.Ivory;
            cvv.BorderStyle = BorderStyle.FixedSingle;
            cvv.Location = new Point(538, 512);
            cvv.Margin = new Padding(3, 4, 3, 4);
            cvv.Name = "cvv";
            cvv.Size = new Size(234, 27);
            cvv.TabIndex = 42;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(218, 488);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 41;
            label4.Text = "NUMERO DE TARJETA:";
            // 
            // cardNum
            // 
            cardNum.Anchor = AnchorStyles.None;
            cardNum.BackColor = Color.Ivory;
            cardNum.BorderStyle = BorderStyle.FixedSingle;
            cardNum.Location = new Point(218, 512);
            cardNum.Margin = new Padding(3, 4, 3, 4);
            cardNum.Name = "cardNum";
            cardNum.Size = new Size(234, 27);
            cardNum.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(538, 457);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 39;
            label3.Text = "CODIGO DE VERFICACION";
            // 
            // cardName
            // 
            cardName.Anchor = AnchorStyles.None;
            cardName.BackColor = Color.Ivory;
            cardName.BorderStyle = BorderStyle.FixedSingle;
            cardName.Location = new Point(218, 390);
            cardName.Margin = new Padding(3, 4, 3, 4);
            cardName.Name = "cardName";
            cardName.Size = new Size(234, 27);
            cardName.TabIndex = 38;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(218, 354);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 37;
            label6.Text = "NOMBRE TITULAR:";
            // 
            // servicePriceLabel
            // 
            servicePriceLabel.Anchor = AnchorStyles.None;
            servicePriceLabel.AutoSize = true;
            servicePriceLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            servicePriceLabel.ForeColor = Color.GreenYellow;
            servicePriceLabel.Location = new Point(555, 584);
            servicePriceLabel.Name = "servicePriceLabel";
            servicePriceLabel.Size = new Size(118, 32);
            servicePriceLabel.TabIndex = 48;
            servicePriceLabel.Text = "2000RD$";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(316, 584);
            label9.Name = "label9";
            label9.Size = new Size(233, 32);
            label9.TabIndex = 47;
            label9.Text = "MONTO A PAGAR:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(218, 644);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(554, 69);
            button1.TabIndex = 46;
            button1.Text = "pagar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PayServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(980, 739);
            Controls.Add(servicePriceLabel);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dateExpired);
            Controls.Add(label5);
            Controls.Add(cvv);
            Controls.Add(label4);
            Controls.Add(cardNum);
            Controls.Add(label3);
            Controls.Add(cardName);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(visaCheck);
            Controls.Add(masterCheck);
            Controls.Add(label2);
            Controls.Add(serviceLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PayServiceForm";
            Text = "VETEN-Pago de Servicio";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label serviceLabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private CheckBox visaCheck;
        private CheckBox masterCheck;
        private Label label2;
        private Label label7;
        private TextBox dateExpired;
        private Label label5;
        private TextBox cvv;
        private Label label4;
        private TextBox cardNum;
        private Label label3;
        private TextBox cardName;
        private Label label6;
        private Label label9;
        private Button button1;
        public Label servicePriceLabel;
    }
}