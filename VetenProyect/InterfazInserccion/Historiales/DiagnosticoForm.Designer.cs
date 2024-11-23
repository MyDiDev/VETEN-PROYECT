namespace VetenProyect.InterfazInserccion.Historiales
{
    partial class DiagnosticoForm
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
            idVisit = new TextBox();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            description = new TextBox();
            date = new DateTimePicker();
            label3 = new Label();
            addBtn = new Button();
            SuspendLayout();
            // 
            // idVisit
            // 
            idVisit.Anchor = AnchorStyles.None;
            idVisit.Location = new Point(81, 63);
            idVisit.Name = "idVisit";
            idVisit.Size = new Size(450, 27);
            idVisit.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(81, 28);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Id de la Visita:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(81, 150);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripcion del Diagnostico:";
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.Location = new Point(81, 185);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(450, 217);
            description.TabIndex = 2;
            // 
            // date
            // 
            date.Location = new Point(81, 492);
            date.Name = "date";
            date.Size = new Size(450, 27);
            date.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(81, 441);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha del Diagnostico:";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(81, 566);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(450, 44);
            addBtn.TabIndex = 6;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // DiagnosticoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 647);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(description);
            Controls.Add(label1);
            Controls.Add(idVisit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DiagnosticoForm";
            Text = "DiagnosticoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idVisit;
        private ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private TextBox description;
        private DateTimePicker date;
        private Label label3;
        private Button addBtn;
    }
}