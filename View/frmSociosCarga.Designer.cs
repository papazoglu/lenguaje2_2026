namespace View
{
    partial class frmSociosCarga
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
            panelDatos = new Panel();
            lblEmail = new Label();
            lblLocalidad = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblDNI = new Label();
            txtDNI = new TextBox();
            cboLocalidad = new ComboBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            flowLayoutPanelInferior = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelDatos.SuspendLayout();
            flowLayoutPanelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(lblEmail);
            panelDatos.Controls.Add(lblLocalidad);
            panelDatos.Controls.Add(lblNombre);
            panelDatos.Controls.Add(lblApellido);
            panelDatos.Controls.Add(lblDireccion);
            panelDatos.Controls.Add(lblDNI);
            panelDatos.Controls.Add(txtDNI);
            panelDatos.Controls.Add(cboLocalidad);
            panelDatos.Controls.Add(txtDireccion);
            panelDatos.Controls.Add(txtEmail);
            panelDatos.Controls.Add(txtNombre);
            panelDatos.Controls.Add(txtApellido);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 0);
            panelDatos.Margin = new Padding(3, 2, 3, 2);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(578, 258);
            panelDatos.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(221, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(411, 93);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 11;
            lblLocalidad.Text = "Localidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(157, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(349, 32);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(28, 93);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(28, 32);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 7;
            lblDNI.Text = "DNI";
            lblDNI.Click += label1_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(28, 49);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(105, 23);
            txtDNI.TabIndex = 6;
            // 
            // cboLocalidad
            // 
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(411, 110);
            cboLocalidad.Margin = new Padding(3, 2, 3, 2);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(142, 23);
            cboLocalidad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(28, 110);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(170, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(221, 110);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 49);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(349, 49);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 23);
            txtApellido.TabIndex = 0;
            // 
            // flowLayoutPanelInferior
            // 
            flowLayoutPanelInferior.Controls.Add(btnCancelar);
            flowLayoutPanelInferior.Controls.Add(btnGuardar);
            flowLayoutPanelInferior.Dock = DockStyle.Bottom;
            flowLayoutPanelInferior.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelInferior.Location = new Point(0, 210);
            flowLayoutPanelInferior.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelInferior.Name = "flowLayoutPanelInferior";
            flowLayoutPanelInferior.Size = new Size(578, 48);
            flowLayoutPanelInferior.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.db_cancel;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(498, 2);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 39);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.save;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(420, 2);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(72, 39);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnAceptar_Click;
            // 
            // frmSociosCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 258);
            Controls.Add(flowLayoutPanelInferior);
            Controls.Add(panelDatos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSociosCarga";
            Text = "frmSociosCarga";
            FormClosed += frmSociosCarga_FormClosed;
            Load += frmSociosCarga_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            flowLayoutPanelInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelDatos;
        private FlowLayoutPanel flowLayoutPanelInferior;
        private ComboBox cboLocalidad;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblDNI;
        private Label lblEmail;
        private Label lblLocalidad;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
    }
}