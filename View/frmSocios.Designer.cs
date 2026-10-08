namespace View
{
    partial class frmSocios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridSocios = new DataGridView();
            flowLayoutPanelInferior = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelSuperior = new Panel();
            panelDatos = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridSocios).BeginInit();
            flowLayoutPanelInferior.SuspendLayout();
            panelDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridSocios
            // 
            dataGridSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSocios.Dock = DockStyle.Fill;
            dataGridSocios.Location = new Point(15, 15);
            dataGridSocios.Name = "dataGridSocios";
            dataGridSocios.RowHeadersWidth = 51;
            dataGridSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSocios.Size = new Size(939, 336);
            dataGridSocios.TabIndex = 3;
            // 
            // flowLayoutPanelInferior
            // 
            flowLayoutPanelInferior.Controls.Add(button1);
            flowLayoutPanelInferior.Controls.Add(button2);
            flowLayoutPanelInferior.Controls.Add(button3);
            flowLayoutPanelInferior.Controls.Add(button4);
            flowLayoutPanelInferior.Dock = DockStyle.Bottom;
            flowLayoutPanelInferior.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelInferior.Location = new Point(0, 426);
            flowLayoutPanelInferior.Name = "flowLayoutPanelInferior";
            flowLayoutPanelInferior.Size = new Size(969, 73);
            flowLayoutPanelInferior.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(867, 3);
            button1.Name = "button1";
            button1.Size = new Size(99, 59);
            button1.TabIndex = 0;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(762, 3);
            button2.Name = "button2";
            button2.Size = new Size(99, 59);
            button2.TabIndex = 1;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(657, 3);
            button3.Name = "button3";
            button3.Size = new Size(99, 59);
            button3.TabIndex = 2;
            button3.Text = "Prestamo carga";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(552, 3);
            button4.Name = "button4";
            button4.Size = new Size(99, 59);
            button4.TabIndex = 3;
            button4.Text = "Carga venta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(969, 60);
            panelSuperior.TabIndex = 5;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(dataGridSocios);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 60);
            panelDatos.Name = "panelDatos";
            panelDatos.Padding = new Padding(15, 15, 15, 15);
            panelDatos.Size = new Size(969, 366);
            panelDatos.TabIndex = 6;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 499);
            Controls.Add(panelDatos);
            Controls.Add(panelSuperior);
            Controls.Add(flowLayoutPanelInferior);
            Name = "frmSocios";
            Text = "Form1";
            Load += frmSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSocios).EndInit();
            flowLayoutPanelInferior.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridSocios;
        private FlowLayoutPanel flowLayoutPanelInferior;
        private Panel panelSuperior;
        private Panel panelDatos;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
