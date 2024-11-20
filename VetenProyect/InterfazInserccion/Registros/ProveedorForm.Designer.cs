namespace VetenProyect.InterfazInserccion.Inventarios
{
    partial class ProveedorForm
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
            contact = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            label3 = new Label();
            mail = new TextBox();
            label4 = new Label();
            direction = new TextBox();
            label5 = new Label();
            condition = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(105, 115);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // contact
            // 
            contact.Location = new Point(105, 246);
            contact.Name = "contact";
            contact.Size = new Size(298, 27);
            contact.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 208);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Contacto:";
            // 
            // phone
            // 
            phone.Location = new Point(105, 369);
            phone.Name = "phone";
            phone.Size = new Size(298, 27);
            phone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 331);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Telefono:";
            // 
            // mail
            // 
            mail.Location = new Point(480, 115);
            mail.Name = "mail";
            mail.Size = new Size(298, 27);
            mail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 77);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // direction
            // 
            direction.Location = new Point(480, 246);
            direction.Name = "direction";
            direction.Size = new Size(298, 27);
            direction.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 208);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion:";
            // 
            // condition
            // 
            condition.Location = new Point(480, 351);
            condition.Multiline = true;
            condition.Name = "condition";
            condition.Size = new Size(298, 89);
            condition.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 313);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 12;
            label6.Text = "Condicion de Entrega:";
            // 
            // button1
            // 
            button1.Location = new Point(96, 496);
            button1.Name = "button1";
            button1.Size = new Size(671, 49);
            button1.TabIndex = 15;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProveedorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 572);
            Controls.Add(button1);
            Controls.Add(condition);
            Controls.Add(label6);
            Controls.Add(direction);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(contact);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "ProveedorForm";
            Text = "VETEN-Agregar Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label label1;
        private TextBox contact;
        private Label label2;
        private TextBox phone;
        private Label label3;
        private TextBox mail;
        private Label label4;
        private TextBox direction;
        private Label label5;
        private TextBox condition;
        private Label label6;
        private Button button1;
    }
}