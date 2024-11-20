namespace VetenProyect
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            adminTaskTypeLabel = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            SuspendLayout();
            // 
            // adminTaskTypeLabel
            // 
            adminTaskTypeLabel.Anchor = AnchorStyles.None;
            adminTaskTypeLabel.Font = new Font("Segoe UI Variable Small Semibol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminTaskTypeLabel.ForeColor = SystemColors.ControlLightLight;
            adminTaskTypeLabel.Location = new Point(210, 64);
            adminTaskTypeLabel.Name = "adminTaskTypeLabel";
            adminTaskTypeLabel.Size = new Size(709, 87);
            adminTaskTypeLabel.TabIndex = 0;
            adminTaskTypeLabel.Text = "INVENTARIOS";
            adminTaskTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.None;
            btn1.BackColor = Color.FromArgb(98, 130, 93);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.ForeColor = SystemColors.ControlLightLight;
            btn1.Location = new Point(196, 243);
            btn1.Name = "btn1";
            btn1.Size = new Size(205, 146);
            btn1.TabIndex = 2;
            btn1.Text = "Medicamentos y Vacunas";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.None;
            btn2.BackColor = Color.FromArgb(98, 130, 93);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.ForeColor = SystemColors.ControlLightLight;
            btn2.Location = new Point(454, 243);
            btn2.Name = "btn2";
            btn2.Size = new Size(205, 146);
            btn2.TabIndex = 3;
            btn2.Text = "Material Médico y Equipamiento";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.None;
            btn3.BackColor = Color.FromArgb(98, 130, 93);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.ForeColor = SystemColors.ControlLightLight;
            btn3.Location = new Point(700, 243);
            btn3.Name = "btn3";
            btn3.Size = new Size(205, 146);
            btn3.TabIndex = 5;
            btn3.Text = "Alimentos y Suplementos";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.None;
            btn5.BackColor = Color.FromArgb(98, 130, 93);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 12F);
            btn5.ForeColor = SystemColors.ControlLightLight;
            btn5.Location = new Point(582, 459);
            btn5.Name = "btn5";
            btn5.Size = new Size(205, 146);
            btn5.TabIndex = 4;
            btn5.Text = "Productos";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.None;
            btn4.BackColor = Color.FromArgb(98, 130, 93);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 12F);
            btn4.ForeColor = SystemColors.ControlLightLight;
            btn4.Location = new Point(315, 459);
            btn4.Name = "btn4";
            btn4.Size = new Size(205, 146);
            btn4.TabIndex = 9;
            btn4.Text = "Documentos y Material Administrativo";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 110, 72);
            ClientSize = new Size(1122, 696);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(adminTaskTypeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form10";
            Text = "VETEN-Inventarios";
            ResumeLayout(false);
        }

        #endregion

        public Label adminTaskTypeLabel;
        private Label label1;
        public Button btn1;
        public Button btn2;
        public Button btn3;
        public Button btn5;
        public Button btn4;
    }
}