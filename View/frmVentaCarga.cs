using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmVentaCarga : Form
    {
        string descripcion;
        decimal precio;
        string codigo;
        int cantidad;
        decimal subtotal;
        ProductoRepository repositoryProducto = new ProductoRepository();


        public frmVentaCarga()
        {
            InitializeComponent();
            txtCantidad.Text = "1";
            cboEstado.SelectedIndex = 1;
            txtCantidad.Select();
            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dgvDetalleVenta.Columns.Add("Codigo", "Código");
            dgvDetalleVenta.Columns.Add("Descripcion", "Descripción");
            dgvDetalleVenta.Columns.Add("Precio", "Precio");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal");
        }



        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvDetalleVenta.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                decimal subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value);

                total = total + subtotal;
            }

            lblTotal.Text = $"Total: {total:C2}";
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            txtCodigo.Focus();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Agrega producto a la grilla
            dgvDetalleVenta.Rows.Add(
                codigo,
                descripcion,
                precio,
                cantidad,
                subtotal
            );

            // método para actualizar el total
            CalcularTotal();

            // limpiamos los campos para ingresar un nuevo producto
            LimpiarCampos();
            txtCantidad.Select();
            txtCantidad.Text = "1";

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProducto();
                e.SuppressKeyPress = true;
            }
        }

        void BuscarProducto()
        {
            Producto producto = repositoryProducto.BuscarPorCodigo(txtCodigo.Text);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }
            descripcion = producto.Descripcion;
            precio = Convert.ToDecimal(producto.PrecioVenta.ToString());
            codigo = producto.Codigo.ToString();

            // obtenemos los datos de los TextBox
            txtDescripcion.Text = descripcion;
            txtPrecio.Text = Convert.ToString(precio);

            cantidad = Convert.ToInt32(txtCantidad.Text);

            // calcula el subtotal
            subtotal = precio * cantidad;
            txtSubTotal.Text = subtotal.ToString();

        }


        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigo.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
