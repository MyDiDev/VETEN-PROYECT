namespace VetenProyect
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            label2 = new Label();
            label1 = new Label();
            nameBoxF1 = new TextBox();
            passBoxF1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            registerLink = new LinkLabel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LawnGreen;
            label2.Location = new Point(200, 126);
            label2.Name = "label2";
            label2.Size = new Size(230, 81);
            label2.TabIndex = 1;
            label2.Text = "VETEN";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(125, 38);
            label1.Name = "label1";
            label1.Size = new Size(409, 62);
            label1.TabIndex = 0;
            label1.Text = "INICIA SESION A";
            // 
            // nameBoxF1
            // 
            nameBoxF1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameBoxF1.BackColor = Color.FromArgb(87, 158, 77);
            nameBoxF1.BorderStyle = BorderStyle.FixedSingle;
            nameBoxF1.ForeColor = SystemColors.ControlLightLight;
            nameBoxF1.Location = new Point(134, 306);
            nameBoxF1.Margin = new Padding(3, 4, 3, 4);
            nameBoxF1.Name = "nameBoxF1";
            nameBoxF1.Size = new Size(357, 27);
            nameBoxF1.TabIndex = 3;
            // 
            // passBoxF1
            // 
            passBoxF1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            passBoxF1.BackColor = Color.FromArgb(87, 158, 77);
            passBoxF1.BorderStyle = BorderStyle.FixedSingle;
            passBoxF1.ForeColor = SystemColors.ControlLightLight;
            passBoxF1.Location = new Point(134, 439);
            passBoxF1.Margin = new Padding(3, 4, 3, 4);
            passBoxF1.Name = "passBoxF1";
            passBoxF1.Size = new Size(357, 27);
            passBoxF1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(134, 382);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 5;
            label3.Text = "CLAVE:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(134, 252);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 6;
            label4.Text = "NOMBRE:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(69, 126, 61);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(134, 617);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(349, 69);
            button1.TabIndex = 7;
            button1.Text = "ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(200, 519);
            label5.Name = "label5";
            label5.Size = new Size(235, 28);
            label5.TabIndex = 8;
            label5.Text = "No tienes una cuenta? ";
            // 
            // registerLink
            // 
            registerLink.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            registerLink.AutoSize = true;
            registerLink.BackColor = Color.Transparent;
            registerLink.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLink.ForeColor = Color.Lime;
            registerLink.LinkColor = Color.Lime;
            registerLink.Location = new Point(264, 554);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(99, 25);
            registerLink.TabIndex = 9;
            registerLink.TabStop = true;
            registerLink.Text = "Registrate";
            registerLink.TextAlign = ContentAlignment.MiddleCenter;
            registerLink.VisitedLinkColor = Color.Green;
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 75, 30);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 715);
            Controls.Add(registerLink);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passBoxF1);
            Controls.Add(nameBoxF1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "VETEN-INICIA SESION";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox nameBoxF1;
        private TextBox passBoxF1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private LinkLabel registerLink;
    }
}
