namespace View
{
    partial class prestamoCarga
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            labelDEsde = new Label();
            labelHasta = new Label();
            panelDatos = new Panel();
            dataGridView1 = new DataGridView();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            flowLayoutPanel1.SuspendLayout();
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Descripción", "Fecha" });
            comboBox1.Location = new Point(13, 12);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Descripción";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(labelDEsde);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(labelHasta);
            flowLayoutPanel1.Controls.Add(dateTimePicker2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(700, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(560, 13);
            button1.Name = "button1";
            button1.Size = new Size(41, 22);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelDEsde
            // 
            labelDEsde.AutoSize = true;
            labelDEsde.Location = new Point(318, 10);
            labelDEsde.Name = "labelDEsde";
            labelDEsde.Size = new Size(39, 15);
            labelDEsde.TabIndex = 3;
            labelDEsde.Text = "Desde";
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Location = new Point(440, 10);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(37, 15);
            labelHasta.TabIndex = 4;
            labelHasta.Text = "Hasta";
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(dataGridView1);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 50);
            panelDatos.Name = "panelDatos";
            panelDatos.Padding = new Padding(10);
            panelDatos.Size = new Size(700, 288);
            panelDatos.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(680, 268);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.Location = new Point(0, 291);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Size = new Size(700, 47);
            flowLayoutPanelBotones.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(363, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(71, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(483, 13);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(71, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // prestamoCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flowLayoutPanelBotones);
            Controls.Add(panelDatos);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "prestamoCarga";
            Text = "prestamoCarga";
            Load += prestamoCarga_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelDatos;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button button1;
        private Label labelDEsde;
        private Label labelHasta;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}