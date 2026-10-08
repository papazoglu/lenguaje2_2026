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
            panelSuperior = new Panel();
            panelDatos = new Panel();
            txtDNI = new TextBox();
            txtIdSocio = new TextBox();
            cboLocalidad = new ComboBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            flowLayoutPanelInferior = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            panelDatos.SuspendLayout();
            flowLayoutPanelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(977, 109);
            panelSuperior.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(txtDNI);
            panelDatos.Controls.Add(txtIdSocio);
            panelDatos.Controls.Add(cboLocalidad);
            panelDatos.Controls.Add(txtDireccion);
            panelDatos.Controls.Add(txtEmail);
            panelDatos.Controls.Add(txtNombre);
            panelDatos.Controls.Add(txtApellido);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 109);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(977, 399);
            panelDatos.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(370, 79);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(194, 27);
            txtDNI.TabIndex = 6;
            // 
            // txtIdSocio
            // 
            txtIdSocio.Location = new Point(99, 79);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(194, 27);
            txtIdSocio.TabIndex = 5;
            // 
            // cboLocalidad
            // 
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(99, 223);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(198, 28);
            cboLocalidad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(370, 147);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(635, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(635, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(99, 147);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 27);
            txtApellido.TabIndex = 0;
            // 
            // flowLayoutPanelInferior
            // 
            flowLayoutPanelInferior.Controls.Add(btnCancelar);
            flowLayoutPanelInferior.Controls.Add(btnAceptar);
            flowLayoutPanelInferior.Dock = DockStyle.Bottom;
            flowLayoutPanelInferior.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelInferior.Location = new Point(0, 421);
            flowLayoutPanelInferior.Name = "flowLayoutPanelInferior";
            flowLayoutPanelInferior.Size = new Size(977, 87);
            flowLayoutPanelInferior.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(880, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 72);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(780, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 72);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmSociosCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 508);
            Controls.Add(flowLayoutPanelInferior);
            Controls.Add(panelDatos);
            Controls.Add(panelSuperior);
            Name = "frmSociosCarga";
            Text = "frmSociosCarga";
            Load += frmSociosCarga_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            flowLayoutPanelInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelDatos;
        private FlowLayoutPanel flowLayoutPanelInferior;
        private ComboBox cboLocalidad;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtIdSocio;
        private TextBox txtDNI;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}