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

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarSocio();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void GuardarSocio()
        {
            Socios socio = new Socios();
            socio.Dni = Convert.ToInt32(this.txtDNI.Text);
            socio.Nombre = this.txtNombre.Text;
            socio.Apellido = this.txtApellido.Text;
            socio.Email = this.txtEmail.Text;
            socio.Direccion = this.txtDireccion.Text;

            socio.IdLocalidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            _socioController.guardarSocio(socio, _accion, _id_socio);

        }

        private void frmSociosCarga_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formSocios.mostrarSocios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
