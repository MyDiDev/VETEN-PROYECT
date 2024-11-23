namespace VetenProyect.InterfazInserccion.Historiales
{
    partial class HistorialMedicoForm
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
            addBtn = new Button();
            label3 = new Label();
            date = new DateTimePicker();
            label2 = new Label();
            notes = new TextBox();
            label1 = new Label();
            idPaciente = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.None;
            addBtn.Location = new Point(79, 576);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(450, 44);
            addBtn.TabIndex = 13;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(79, 451);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Fecha:";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.None;
            date.Location = new Point(79, 502);
            date.Name = "date";
            date.Size = new Size(450, 27);
            date.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(79, 160);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 10;
            label2.Text = "Notas Generales:";
            // 
            // notes
            // 
            notes.Anchor = AnchorStyles.None;
            notes.Location = new Point(79, 195);
            notes.Multiline = true;
            notes.Name = "notes";
            notes.Size = new Size(450, 217);
            notes.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(79, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Id del Paciente:";
            // 
            // idPaciente
            // 
            idPaciente.Anchor = AnchorStyles.None;
            idPaciente.Location = new Point(79, 78);
            idPaciente.Name = "idPaciente";
            idPaciente.Size = new Size(450, 27);
            idPaciente.TabIndex = 7;
            // 
            // HistorialMedicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 659);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(notes);
            Controls.Add(label1);
            Controls.Add(idPaciente);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HistorialMedicoForm";
            Text = "Historial Medico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label3;
        private DateTimePicker date;
        private Label label2;
        private TextBox notes;
        private Label label1;
        private TextBox idPaciente;
    }
}