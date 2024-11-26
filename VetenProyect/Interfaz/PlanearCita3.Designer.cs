namespace VetenProyect
{
    partial class PlanearCita3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanearCita3));
            label1 = new Label();
            label2 = new Label();
            masterCheck = new CheckBox();
            visaCheck = new CheckBox();
            cardName = new TextBox();
            label6 = new Label();
            cardNum = new TextBox();
            label3 = new Label();
            cvv = new TextBox();
            label4 = new Label();
            dateExpired = new TextBox();
            label5 = new Label();
            label7 = new Label();
            button1 = new Button();
            label9 = new Label();
            priceLabel = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(251, 45);
            label1.Name = "label1";
            label1.Size = new Size(373, 62);
            label1.TabIndex = 5;
            label1.Text = "PLANEAR CITA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(347, 150);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 6;
            label2.Text = "ELIGE EL TIPO DE TARJETA:";
            // 
            // masterCheck
            // 
            masterCheck.Anchor = AnchorStyles.None;
            masterCheck.AutoSize = true;
            masterCheck.Cursor = Cursors.Hand;
            masterCheck.ForeColor = SystemColors.ControlLightLight;
            masterCheck.Location = new Point(293, 300);
            masterCheck.Margin = new Padding(3, 4, 3, 4);
            masterCheck.Name = "masterCheck";
            masterCheck.Size = new Size(126, 24);
            masterCheck.TabIndex = 9;
            masterCheck.Text = "MASTERCARD";
            masterCheck.UseVisualStyleBackColor = true;
            // 
            // visaCheck
            // 
            visaCheck.Anchor = AnchorStyles.None;
            visaCheck.AutoSize = true;
            visaCheck.Cursor = Cursors.Hand;
            visaCheck.ForeColor = SystemColors.ControlLightLight;
            visaCheck.Location = new Point(516, 300);
            visaCheck.Margin = new Padding(3, 4, 3, 4);
            visaCheck.Name = "visaCheck";
            visaCheck.Size = new Size(62, 24);
            visaCheck.TabIndex = 10;
            visaCheck.Text = "VISA";
            visaCheck.UseVisualStyleBackColor = true;
            // 
            // cardName
            // 
            cardName.Anchor = AnchorStyles.None;
            cardName.BackColor = Color.Ivory;
            cardName.BorderStyle = BorderStyle.FixedSingle;
            cardName.ForeColor = Color.Black;
            cardName.Location = new Point(175, 428);
            cardName.Margin = new Padding(3, 4, 3, 4);
            cardName.Name = "cardName";
            cardName.Size = new Size(234, 27);
            cardName.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(175, 392);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 15;
            label6.Text = "NOMBRE TITULAR:";
            // 
            // cardNum
            // 
            cardNum.Anchor = AnchorStyles.None;
            cardNum.BackColor = Color.Ivory;
            cardNum.BorderStyle = BorderStyle.FixedSingle;
            cardNum.ForeColor = Color.Black;
            cardNum.Location = new Point(175, 550);
            cardNum.Margin = new Padding(3, 4, 3, 4);
            cardNum.Name = "cardNum";
            cardNum.Size = new Size(234, 27);
            cardNum.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(495, 495);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 17;
            label3.Text = "CODIGO DE VERFICACION";
            // 
            // cvv
            // 
            cvv.Anchor = AnchorStyles.None;
            cvv.BackColor = Color.Ivory;
            cvv.BorderStyle = BorderStyle.FixedSingle;
            cvv.ForeColor = Color.Black;
            cvv.Location = new Point(495, 550);
            cvv.Margin = new Padding(3, 4, 3, 4);
            cvv.Name = "cvv";
            cvv.Size = new Size(234, 27);
            cvv.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(175, 526);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 19;
            label4.Text = "NUMERO DE TARJETA:";
            // 
            // dateExpired
            // 
            dateExpired.Anchor = AnchorStyles.None;
            dateExpired.BackColor = Color.Ivory;
            dateExpired.BorderStyle = BorderStyle.FixedSingle;
            dateExpired.ForeColor = Color.Black;
            dateExpired.Location = new Point(495, 428);
            dateExpired.Margin = new Padding(3, 4, 3, 4);
            dateExpired.Name = "dateExpired";
            dateExpired.Size = new Size(234, 27);
            dateExpired.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(495, 392);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 21;
            label5.Text = "FECHA DE EXPIRACION:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(495, 526);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 23;
            label7.Text = "(CVV O CVC):";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(175, 686);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(554, 69);
            button1.TabIndex = 26;
            button1.Text = "pagar y planear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(272, 612);
            label9.Name = "label9";
            label9.Size = new Size(233, 32);
            label9.TabIndex = 28;
            label9.Text = "MONTO A PAGAR:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = Color.GreenYellow;
            priceLabel.Location = new Point(490, 612);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(118, 32);
            priceLabel.TabIndex = 29;
            priceLabel.Text = "2000RD$";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(491, 214);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(293, 214);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // PlanearCita3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(916, 768);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(priceLabel);
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
            Controls.Add(visaCheck);
            Controls.Add(masterCheck);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlanearCita3";
            Text = "VETEN-PLANEAR CITA PAGO";
            Load += PlanearCita3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox masterCheck;
        private CheckBox visaCheck;
        private TextBox cardName;
        private Label label6;
        private TextBox cardNum;
        private Label label3;
        private TextBox cvv;
        private Label label4;
        private TextBox dateExpired;
        private Label label5;
        private Label label7;
        private Button button1;
        private Label label9;
        private Label priceLabel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}