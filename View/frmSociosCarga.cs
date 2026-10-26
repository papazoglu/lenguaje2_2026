using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmSociosCarga : Form
    {
        int _accion;
        bool _editado;
        int _id_socio;
        private frmSocios _formSocios;
        public SociosController _socioController = new SociosController();

        //constructor para el update
        public frmSociosCarga(Socios socio, int accion, frmSocios frmSocios)
        {
            InitializeComponent();

            this.txtNombre.Text = Convert.ToString(socio.Nombre);
            this.txtDNI.Text = Convert.ToString(socio.Dni);
            _id_socio = Convert.ToInt32(socio.IdSocio);
            this.txtEmail.Text = Convert.ToString(socio.Email);
            this.txtDireccion.Text = Convert.ToString(socio.Direccion);
            this.txtApellido.Text = Convert.ToString(socio.Apellido);
            _accion = accion;
            this._formSocios = frmSocios;
            this.CargarLocalidades();
            this.cboLocalidad.SelectedValue = socio.IdLocalidad;


        }
        //constructor para el insert
        public frmSociosCarga(int accion, frmSocios frmSocios)
        {
            InitializeComponent();
            _accion = accion;
            this._formSocios = frmSocios;
            this.CargarLocalidades();
            txtDNI.Select();
        }

        private void CargarLocalidades()
        {
            var localidades = _socioController.CargarComboLocalidades();

            //// Asignar el DataSource al ComboBox
            this.cboLocalidad.DataSource = localidades;
            this.cboLocalidad.DisplayMember = "NombreLocalidad"; // Propiedad para mostrar
            this.cboLocalidad.ValueMember = "Id_localidad";       // Propiedad como valor

        }

        private void frmSociosCarga_Load(object sender, EventArgs e)
        {
            _editado = false;
        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(
                    txtNombre,
                    "El nombre es obligatorio."
                );

                return false;
            }

            errorProvider1.SetError(txtNombre, "");
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
            _editado=false;    
            //unificar las validaciones de campos en la vista o en el cotrolador
                if (!ValidarNombre())
                {
                    txtNombre.Focus();
                    return;
                }

                if (GuardarSocio())
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private bool GuardarSocio()
        {
            Socios socio = new Socios();
            socio.Dni = Convert.ToInt32(this.txtDNI.Text);
            socio.Nombre = this.txtNombre.Text;
            socio.Apellido = this.txtApellido.Text;
            socio.Email = this.txtEmail.Text;
            socio.Direccion = this.txtDireccion.Text;

            if (!_socioController.ValidarEmail(socio.Email))
            {
                MessageBox.Show(
                    "Ingrese una dirección de correo electrónico válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }

            socio.IdLocalidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            return _socioController.guardarSocio(socio, _accion, _id_socio);

        }

        private void frmSociosCarga_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formSocios.mostrarSocios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        _editado=false;    
        this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "");
            }
            _editado = true;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            _editado = true;
        }

        private void frmSociosCarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_editado){
                
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar el formulario sin guardar los cambios?","Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;    
                    // No se cierra el formulario
                }

            }
        }
    }
}
