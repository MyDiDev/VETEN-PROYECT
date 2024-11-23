namespace VetenProyect.InterfazInserccion.Historiales
{
    partial class VisitaForm
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
            label1 = new Label();
            label2 = new Label();
            reazon = new TextBox();
            date = new DateTimePicker();
            label3 = new Label();
            wheight = new TextBox();
            label4 = new Label();
            temperature = new TextBox();
            addBtn = new Button();
            label5 = new Label();
            notes = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(145, 51);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 5;
            label1.Text = "Fecha de La visita:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(145, 157);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Motivo:";
            // 
            // reazon
            // 
            reazon.Anchor = AnchorStyles.None;
            reazon.Location = new Point(145, 192);
            reazon.Multiline = true;
            reazon.Name = "reazon";
            reazon.Size = new Size(383, 69);
            reazon.TabIndex = 6;
            // 
            // date
            // 
            date.Location = new Point(145, 86);
            date.Name = "date";
            date.Size = new Size(383, 27);
            date.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(145, 304);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Peso:";
            // 
            // wheight
            // 
            wheight.Anchor = AnchorStyles.None;
            wheight.Location = new Point(145, 339);
            wheight.Name = "wheight";
            wheight.Size = new Size(383, 27);
            wheight.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(145, 410);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 12;
            label4.Text = "Temperatura C°:";
            // 
            // temperature
            // 
            temperature.Anchor = AnchorStyles.None;
            temperature.Location = new Point(145, 445);
            temperature.Name = "temperature";
            temperature.Size = new Size(383, 27);
            temperature.TabIndex = 11;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(145, 643);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(383, 41);
            addBtn.TabIndex = 13;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(145, 509);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 15;
            label5.Text = "Notas:";
            // 
            // notes
            // 
            notes.Anchor = AnchorStyles.None;
            notes.Location = new Point(145, 544);
            notes.Multiline = true;
            notes.Name = "notes";
            notes.Size = new Size(383, 69);
            notes.TabIndex = 14;
            // 
            // VisitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 696);
            Controls.Add(label5);
            Controls.Add(notes);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(temperature);
            Controls.Add(label3);
            Controls.Add(wheight);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(reazon);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VisitaForm";
            Text = "VisitaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox reazon;
        private DateTimePicker date;
        private Label label3;
        private TextBox wheight;
        private Label label4;
        private TextBox temperature;
        private Button addBtn;
        private Label label5;
        private TextBox notes;
    }
}