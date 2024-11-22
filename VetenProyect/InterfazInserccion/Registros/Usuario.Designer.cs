namespace VetenProyect.InterfazInserccion.Registros
{
    partial class Usuario
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
            name = new TextBox();
            label1 = new Label();
            location = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label4 = new Label();
            password = new TextBox();
            label5 = new Label();
            addBtn = new Button();
            userType = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Location = new Point(43, 69);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre del Usuario:";
            // 
            // location
            // 
            location.Anchor = AnchorStyles.None;
            location.Location = new Point(43, 186);
            location.Name = "location";
            location.Size = new Size(298, 27);
            location.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(43, 148);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 20;
            label2.Text = "Direccion:";
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.None;
            phone.Location = new Point(384, 69);
            phone.Name = "phone";
            phone.Size = new Size(298, 27);
            phone.TabIndex = 23;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(384, 31);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 22;
            label3.Text = "Telefono:";
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Location = new Point(384, 180);
            email.Name = "email";
            email.Size = new Size(298, 27);
            email.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(384, 142);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 24;
            label4.Text = "Email:";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.Location = new Point(43, 290);
            password.Name = "password";
            password.Size = new Size(298, 27);
            password.TabIndex = 27;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(43, 252);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 26;
            label5.Text = "Clave/Contraseña:";
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Location = new Point(43, 362);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(639, 37);
            addBtn.TabIndex = 28;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // userType
            // 
            userType.Anchor = AnchorStyles.None;
            userType.FormattingEnabled = true;
            userType.Items.AddRange(new object[] { "Admin", "Usuario" });
            userType.Location = new Point(384, 290);
            userType.Name = "userType";
            userType.Size = new Size(298, 28);
            userType.TabIndex = 31;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(384, 252);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 30;
            label6.Text = "Tipo de usuario:";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 435);
            Controls.Add(userType);
            Controls.Add(label6);
            Controls.Add(addBtn);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(location);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Usuario";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label1;
        private TextBox location;
        private Label label2;
        private TextBox phone;
        private Label label3;
        private TextBox email;
        private Label label4;
        private TextBox password;
        private Label label5;
        private Button addBtn;
        private ComboBox userType;
        private Label label6;
    }
}