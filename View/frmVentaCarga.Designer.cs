namespace View
{
    partial class frmVentaCarga
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
            btnAgregar = new Button();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            dgvDetalleVenta = new DataGridView();
            lblTotal = new Label();
            lblCantidad = new Label();
            lblCodigo = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            txtSubTotal = new TextBox();
            lblSubTotal = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboEstado = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(800, 328);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 45);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(149, 346);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 27);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(39, 346);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(69, 27);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyDown += txtCantidad_KeyDown;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(281, 346);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(548, 346);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 27);
            txtPrecio.TabIndex = 5;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(40, 381);
            dgvDetalleVenta.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(878, 245);
            dgvDetalleVenta.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(868, 643);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label1";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(39, 322);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(149, 322);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Código";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(548, 322);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(281, 322);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(675, 346);
            txtSubTotal.Margin = new Padding(3, 4, 3, 4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(110, 27);
            txtSubTotal.TabIndex = 12;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(675, 322);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(67, 20);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "SubTotal";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 123);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(743, 28);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 18;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 24);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 17;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 24);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 16;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 15;
            label1.Text = "Nro Mesa";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Cerrada", "Abierta" });
            cboEstado.Location = new Point(743, 51);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(158, 28);
            cboEstado.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(531, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 0;
            // 
            // frmVentaCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 686);
            Controls.Add(panel1);
            Controls.Add(lblSubTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(lblCantidad);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentaCarga";
            Text = "frmVentaCarga";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private DataGridView dgvDetalleVenta;
        private Label lblTotal;
        private Label lblCantidad;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblDescripcion;
        private TextBox txtSubTotal;
        private Label lblSubTotal;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboEstado;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}