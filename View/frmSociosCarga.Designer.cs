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
            components = new System.ComponentModel.Container();
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
            errorProvider1 = new ErrorProvider(components);
            panelDatos.SuspendLayout();
            flowLayoutPanelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(654, 344);
            panelDatos.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(253, 124);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail";
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(470, 124);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(74, 20);
            lblLocalidad.TabIndex = 11;
            lblLocalidad.Text = "Localidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(179, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(399, 43);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(32, 124);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(32, 43);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 7;
            lblDNI.Text = "DNI";
            lblDNI.Click += label1_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(32, 65);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(119, 27);
            txtDNI.TabIndex = 6;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // cboLocalidad
            // 
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(470, 147);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(162, 28);
            cboLocalidad.TabIndex = 4;
            cboLocalidad.SelectedIndexChanged += cboLocalidad_SelectedIndexChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(32, 147);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(253, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(399, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 27);
            txtApellido.TabIndex = 0;
            // 
            // flowLayoutPanelInferior
            // 
            flowLayoutPanelInferior.Controls.Add(btnCancelar);
            flowLayoutPanelInferior.Controls.Add(btnGuardar);
            flowLayoutPanelInferior.Dock = DockStyle.Bottom;
            flowLayoutPanelInferior.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelInferior.Location = new Point(0, 280);
            flowLayoutPanelInferior.Name = "flowLayoutPanelInferior";
            flowLayoutPanelInferior.Size = new Size(654, 64);
            flowLayoutPanelInferior.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.db_cancel;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(563, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 52);
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
            btnGuardar.Location = new Point(475, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 52);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSociosCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 344);
            Controls.Add(flowLayoutPanelInferior);
            Controls.Add(panelDatos);
            Name = "frmSociosCarga";
            Text = "frmSociosCarga";
            FormClosing += frmSociosCarga_FormClosing;
            FormClosed += frmSociosCarga_FormClosed;
            Load += frmSociosCarga_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            flowLayoutPanelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}