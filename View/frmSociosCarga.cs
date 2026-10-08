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
        private frmSocios _formSocios;
        public SociosController _socioController = new SociosController();

        public frmSociosCarga(Socios socio, int accion, frmSocios frmSocios)
        {
            InitializeComponent();
           
            this.txtNombre.Text = Convert.ToString(socio.Nombre);
            this.txtDNI.Text = Convert.ToString(socio.Dni);
            this.txtIdSocio.Text = Convert.ToString(socio.IdSocio);
            this.txtEmail.Text = Convert.ToString(socio.Email);
            this.txtDireccion.Text = Convert.ToString(socio.Direccion);
            this.txtApellido.Text = Convert.ToString(socio.Apellido);
            _accion = accion;
            this._formSocios = frmSocios;
            this.CargarLocalidades();
            this.cboLocalidad.SelectedValue = socio.IdLocalidad;
            

        }

        private void CargarLocalidades()
        {
            _formSocios.mostrarSocios();
            var localidades = _socioController.CargarComboLocalidades();

            //// Asignar el DataSource al ComboBox
            this.cboLocalidad.DataSource = localidades;
            this.cboLocalidad.DisplayMember = "NombreLocalidad"; // Propiedad para mostrar
            this.cboLocalidad.ValueMember = "Id_localidad";       // Propiedad como valor

        }

        private void frmSociosCarga_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarSocio();
        }

        private void GuardarSocio()
        {
            Socios socio = new Socios();
            socio.Dni = Convert.ToInt32(this.txtDNI.Text);
            socio.Nombre = this.txtNombre.Text;
            socio.Apellido = this.txtApellido.Text;
            socio.Email = this.txtEmail.Text;
            socio.Direccion = this.txtDireccion.Text;
            socio.IdSocio = Convert.ToInt32(this.txtIdSocio.Text);
            socio.IdLocalidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            //socio.IdLocalidad = (this.cboLocalidad.SelectedValue.ToString());
            //if (string.IsNullOrEmpty(this.txtId.Text))
            //{
            //    alumno.Id = 0;
            //}
            //else
            //{
            //    alumno.Id = Convert.ToInt32(this.txtId.Text);
            //}

            //if (_accion == 2){
                _socioController.guardarSocio(socio, _accion);
            //}else{

//            }

        }
    }
}
