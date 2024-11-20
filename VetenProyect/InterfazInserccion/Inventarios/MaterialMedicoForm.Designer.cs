namespace VetenProyect.InterfazInserccion
{
    partial class MaterialMedicoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialMedicoForm));
            amount = new TextBox();
            label6 = new Label();
            unitaryPrice = new TextBox();
            label5 = new Label();
            label3 = new Label();
            description = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            checkDate = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // amount
            // 
            amount.Location = new Point(456, 104);
            amount.Name = "amount";
            amount.Size = new Size(298, 27);
            amount.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 66);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 20;
            label6.Text = "Cantidad:";
            // 
            // unitaryPrice
            // 
            unitaryPrice.Location = new Point(278, 410);
            unitaryPrice.Name = "unitaryPrice";
            unitaryPrice.Size = new Size(298, 27);
            unitaryPrice.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 368);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 18;
            label5.Text = "Precio Unitario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 195);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 16;
            label3.Text = "Fecha de Mantenimiento:";
            // 
            // description
            // 
            description.Location = new Point(97, 233);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(298, 90);
            description.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 195);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 14;
            label2.Text = "Descripcion:";
            // 
            // name
            // 
            name.Location = new Point(97, 104);
            name.Name = "name";
            name.Size = new Size(298, 27);
            name.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 66);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // checkDate
            // 
            checkDate.Location = new Point(456, 231);
            checkDate.Name = "checkDate";
            checkDate.Size = new Size(298, 27);
            checkDate.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(97, 499);
            button1.Name = "button1";
            button1.Size = new Size(657, 49);
            button1.TabIndex = 23;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MaterialMedicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 566);
            Controls.Add(button1);
            Controls.Add(checkDate);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(unitaryPrice);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(description);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MaterialMedicoForm";
            Text = "VETEN-Agregar Material Medico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox amount;
        private Label label6;
        private TextBox unitaryPrice;
        private Label label5;
        private Label label3;
        private TextBox description;
        private Label label2;
        private TextBox name;
        private Label label1;
        private DateTimePicker checkDate;
        private Button button1;
    }
}