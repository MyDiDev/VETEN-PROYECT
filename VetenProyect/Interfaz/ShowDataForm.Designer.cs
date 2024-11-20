namespace VetenProyect
{
    partial class ShowDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDataForm));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            addBtn = new Button();
            deleteBtn = new Button();
            modifyBtn = new Button();
            searchBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1149, 457);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(1149, 38);
            label1.TabIndex = 5;
            label1.Text = "HISTORIAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addBtn.Cursor = Cursors.Hand;
            addBtn.Location = new Point(33, 625);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(1152, 43);
            addBtn.TabIndex = 6;
            addBtn.Text = "AGREGAR";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Location = new Point(33, 685);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(1152, 43);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "ELIMINAR";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modifyBtn.Cursor = Cursors.Hand;
            modifyBtn.Location = new Point(33, 751);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(1152, 43);
            modifyBtn.TabIndex = 8;
            modifyBtn.Text = "MODIFICAR";
            modifyBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.Location = new Point(30, 872);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(1152, 43);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "BUSCAR";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(117, 819);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(751, 819);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 27);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(84, 822);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 12;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(678, 822);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 13;
            label3.Text = "Nombre:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(30, 938);
            button1.Name = "button1";
            button1.Size = new Size(1152, 43);
            button1.TabIndex = 14;
            button1.Text = "CARGAR DATOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ShowDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 1026);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(searchBtn);
            Controls.Add(modifyBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowDataForm";
            Text = "VETEN-Historial de Interacciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridView1;
        public Label label1;
        private Button addBtn;
        private Button deleteBtn;
        private Button modifyBtn;
        private Button searchBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}