namespace VetenProyect.Interfaz
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            panelBarraLateral = new Panel();
            closeFormBtn = new FontAwesome.Sharp.IconButton();
            adminMark = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            btnHistoriales = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnRegistrarMascota = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            productBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            formPanel = new Panel();
            timeLabel = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconDropDownButton2 = new FontAwesome.Sharp.IconDropDownButton();
            iconDropDownButton3 = new FontAwesome.Sharp.IconDropDownButton();
            panelBarraLateral.SuspendLayout();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panelBarraLateral
            // 
            panelBarraLateral.AutoScroll = true;
            panelBarraLateral.BackColor = Color.FromArgb(98, 130, 93);
            panelBarraLateral.Controls.Add(closeFormBtn);
            panelBarraLateral.Controls.Add(adminMark);
            panelBarraLateral.Controls.Add(label6);
            panelBarraLateral.Controls.Add(iconButton7);
            panelBarraLateral.Controls.Add(btnHistoriales);
            panelBarraLateral.Controls.Add(btnInventario);
            panelBarraLateral.Controls.Add(btnRegistrarMascota);
            panelBarraLateral.Controls.Add(iconButton4);
            panelBarraLateral.Controls.Add(iconButton3);
            panelBarraLateral.Controls.Add(productBtn);
            panelBarraLateral.Controls.Add(iconButton1);
            panelBarraLateral.Dock = DockStyle.Left;
            panelBarraLateral.Location = new Point(0, 0);
            panelBarraLateral.Name = "panelBarraLateral";
            panelBarraLateral.Size = new Size(383, 803);
            panelBarraLateral.TabIndex = 0;
            // 
            // closeFormBtn
            // 
            closeFormBtn.Anchor = AnchorStyles.None;
            closeFormBtn.BackColor = Color.FromArgb(82, 110, 72);
            closeFormBtn.Cursor = Cursors.Hand;
            closeFormBtn.FlatAppearance.BorderSize = 0;
            closeFormBtn.FlatStyle = FlatStyle.Flat;
            closeFormBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeFormBtn.ForeColor = SystemColors.ControlLightLight;
            closeFormBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            closeFormBtn.IconColor = Color.Transparent;
            closeFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeFormBtn.Location = new Point(-2, 737);
            closeFormBtn.Name = "closeFormBtn";
            closeFormBtn.Size = new Size(385, 66);
            closeFormBtn.TabIndex = 25;
            closeFormBtn.Text = "Cerrar Ventana";
            closeFormBtn.UseVisualStyleBackColor = false;
            closeFormBtn.Click += closeFormBtn_Click;
            // 
            // adminMark
            // 
            adminMark.FlatAppearance.BorderSize = 0;
            adminMark.FlatStyle = FlatStyle.Flat;
            adminMark.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMark.ForeColor = Color.FromArgb(82, 110, 72);
            adminMark.IconChar = FontAwesome.Sharp.IconChar.A;
            adminMark.IconColor = Color.FromArgb(82, 110, 72);
            adminMark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminMark.Location = new Point(314, 12);
            adminMark.Name = "adminMark";
            adminMark.Size = new Size(66, 60);
            adminMark.TabIndex = 25;
            adminMark.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 38);
            label6.Name = "label6";
            label6.Size = new Size(221, 80);
            label6.TabIndex = 37;
            label6.Text = "VETEN";
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.Transparent;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton7.ForeColor = SystemColors.ControlLightLight;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(-2, 647);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(10, 0, 0, 0);
            iconButton7.Size = new Size(385, 72);
            iconButton7.TabIndex = 35;
            iconButton7.Text = "Registros";
            iconButton7.TextAlign = ContentAlignment.MiddleLeft;
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Visible = false;
            iconButton7.Click += iconButton7_Click;
            // 
            // btnHistoriales
            // 
            btnHistoriales.BackColor = Color.Transparent;
            btnHistoriales.FlatAppearance.BorderSize = 0;
            btnHistoriales.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            btnHistoriales.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            btnHistoriales.FlatStyle = FlatStyle.Flat;
            btnHistoriales.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistoriales.ForeColor = SystemColors.ControlLightLight;
            btnHistoriales.IconChar = FontAwesome.Sharp.IconChar.BookQuran;
            btnHistoriales.IconColor = Color.White;
            btnHistoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistoriales.Location = new Point(0, 576);
            btnHistoriales.Name = "btnHistoriales";
            btnHistoriales.Padding = new Padding(10, 0, 0, 0);
            btnHistoriales.Size = new Size(383, 76);
            btnHistoriales.TabIndex = 33;
            btnHistoriales.Text = "Historiales";
            btnHistoriales.TextAlign = ContentAlignment.MiddleLeft;
            btnHistoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistoriales.UseVisualStyleBackColor = false;
            btnHistoriales.Visible = false;
            btnHistoriales.Click += btnHistoriales_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Transparent;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = SystemColors.ControlLightLight;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnInventario.IconColor = Color.White;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(-2, 505);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 0, 0);
            btnInventario.Size = new Size(385, 76);
            btnInventario.TabIndex = 26;
            btnInventario.Text = "Inventarios";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Visible = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnRegistrarMascota
            // 
            btnRegistrarMascota.BackColor = Color.Transparent;
            btnRegistrarMascota.FlatAppearance.BorderSize = 0;
            btnRegistrarMascota.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            btnRegistrarMascota.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            btnRegistrarMascota.FlatStyle = FlatStyle.Flat;
            btnRegistrarMascota.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarMascota.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarMascota.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnRegistrarMascota.IconColor = Color.White;
            btnRegistrarMascota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarMascota.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarMascota.Location = new Point(-2, 435);
            btnRegistrarMascota.Name = "btnRegistrarMascota";
            btnRegistrarMascota.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarMascota.Size = new Size(385, 74);
            btnRegistrarMascota.TabIndex = 23;
            btnRegistrarMascota.Text = "Registrar Mascota";
            btnRegistrarMascota.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarMascota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarMascota.UseVisualStyleBackColor = false;
            btnRegistrarMascota.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = SystemColors.ControlLightLight;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(-2, 362);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 0, 0);
            iconButton4.Size = new Size(385, 75);
            iconButton4.TabIndex = 21;
            iconButton4.Text = "Citas/Recordatorios";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(-2, 291);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 0, 0);
            iconButton3.Size = new Size(385, 74);
            iconButton3.TabIndex = 20;
            iconButton3.Text = "Servicios";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.Transparent;
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            productBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productBtn.ForeColor = SystemColors.ControlLightLight;
            productBtn.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            productBtn.IconColor = Color.White;
            productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            productBtn.ImageAlign = ContentAlignment.MiddleLeft;
            productBtn.Location = new Point(0, 226);
            productBtn.Name = "productBtn";
            productBtn.Padding = new Padding(10, 0, 0, 0);
            productBtn.Size = new Size(383, 66);
            productBtn.TabIndex = 19;
            productBtn.Text = "Productos";
            productBtn.TextAlign = ContentAlignment.MiddleLeft;
            productBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 110, 72);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 110, 72);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 155);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(380, 76);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Planear Cita";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // formPanel
            // 
            formPanel.AutoScroll = true;
            formPanel.BackColor = Color.FromArgb(82, 110, 72);
            formPanel.Controls.Add(timeLabel);
            formPanel.Controls.Add(iconPictureBox5);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(383, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(934, 803);
            formPanel.TabIndex = 25;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.None;
            timeLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = SystemColors.ControlLightLight;
            timeLabel.Location = new Point(240, 480);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(497, 109);
            timeLabel.TabIndex = 23;
            timeLabel.Text = "VETEN";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.Anchor = AnchorStyles.None;
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Paw;
            iconPictureBox5.IconColor = SystemColors.ControlLightLight;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 255;
            iconPictureBox5.Location = new Point(299, 205);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(360, 255);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox5.TabIndex = 24;
            iconPictureBox5.TabStop = false;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // iconDropDownButton2
            // 
            iconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton2.IconColor = Color.Black;
            iconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton2.Name = "iconDropDownButton2";
            iconDropDownButton2.Size = new Size(23, 23);
            iconDropDownButton2.Text = "iconDropDownButton2";
            // 
            // iconDropDownButton3
            // 
            iconDropDownButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton3.IconColor = Color.Black;
            iconDropDownButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton3.Name = "iconDropDownButton3";
            iconDropDownButton3.Size = new Size(23, 23);
            iconDropDownButton3.Text = "iconDropDownButton3";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 803);
            Controls.Add(formPanel);
            Controls.Add(panelBarraLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form14";
            Text = "Main";
            Load += Form14_Load;
            panelBarraLateral.ResumeLayout(false);
            panelBarraLateral.PerformLayout();
            formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraLateral;
        private Panel BarraTitle;
        private Panel formPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton2;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton btnRegistrarMascota;
        private Label timeLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton6;
        public FontAwesome.Sharp.IconButton adminMark;
        public FontAwesome.Sharp.IconButton btnInventario;
        public FontAwesome.Sharp.IconButton btnHistoriales;
        public FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton closeFormBtn;
    }
}