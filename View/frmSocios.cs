using Controller;
using Model;
using System.Globalization;

namespace View
{
    public partial class frmSocios : Form
    {
        SociosController _sociosController = new SociosController();

        public frmSocios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString($"ups: {ex.Message}"));
            }
            finally
            {


            }


        }



        private void frmSocios_Load(object sender, EventArgs e)
        {
            mostrarSocios();
            diseñoDatagridSocios();
        }

        private void diseñoDatagridSocios()
        {
            if (this.dataGridSocios.Columns["id_socio"] != null)
            {
                this.dataGridSocios.Columns["id_socio"].Width = 10;
            }

            //frmMovimientoStock.DataGridMovimientoStock.Columns(0).Visible = False

            //frmMovimientoStock.DataGridMovimientoStock.Columns(1).Width = 60
            //frmMovimientoStock.DataGridMovimientoStock.Columns("producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            //'frmMovimientoStock.DataGridMovimientoStock.Columns(2).Width = 218
            //frmMovimientoStock.DataGridMovimientoStock.Columns(3).Width = 70
            //frmMovimientoStock.DataGridMovimientoStock.Columns(4).Width = 70
            //frmMovimientoStock.DataGridMovimientoStock.Columns(5).Width = 70
            //frmMovimientoStock.DataGridMovimientoStock.Columns(6).Width = 110
            //frmMovimientoStock.DataGridMovimientoStock.Columns(7).Width = 100



            //frmMovimientoStock.DataGridMovimientoStock.Columns(1).HeaderText = "IdProducto"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(2).HeaderText = "Descripción"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(3).HeaderText = "Ajuste"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(4).HeaderText = "Stock final"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(5).HeaderText = "Stock anterior"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(6).HeaderText = "Tipo Movimiento"
            //frmMovimientoStock.DataGridMovimientoStock.Columns(7).HeaderText = "Fecha"


            //frmMovimientoStock.DataGridMovimientoStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            //'frmProductos.DataGridView1.Columns(14).Visible = False


            //frmMovimientoStock.DataGridMovimientoStock.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        }

        public void mostrarSocios()
        {
            this.dataGridSocios.DataSource = _sociosController.listarSocios();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        //    switch (e.KeyChar)
        //    {
        //        case (char)Keys.Return:
        //            this.textBox1.Focus();
        //            e.Handled = true; // Evita el beep al pulsar ENTER
        //            break;

        //        case char c when c.ToString() == sep:
        //            e.Handled = false;
        //            break;

        //        case char c when c >= '0' && c <= '9':
        //            e.Handled = false;
        //            break;

        //        case '\b': // Backspace
        //            e.Handled = false;
        //            break;
        //        case '+':
        //            e.Handled = false;
        //            break;

        //        default:
        //            e.Handled = true;
        //            break;
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            modificarPrestamo();

        }

        private void modificarPrestamo()
        {
            try
            {
                if (this.dataGridSocios.CurrentRow != null)
                {
                    Socios socio = new Socios();

                    socio.Nombre = this.dataGridSocios.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                    socio.Dni = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["Dni"].Value);
                    socio.Apellido = this.dataGridSocios.CurrentRow.Cells["Apellido"].Value?.ToString() ?? "";
                    socio.Direccion = this.dataGridSocios.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
                    socio.Email = this.dataGridSocios.CurrentRow.Cells["Email"].Value?.ToString() ?? "";
                    socio.IdLocalidad = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["IdLocalidad"].Value);
                    socio.IdSocio = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["IdSocio"].Value);

                    MessageBox.Show($"nombre seleccionado: {socio.Nombre}");

                    Form sociosCarga = new frmSociosCarga(socio, 2, this);
                    sociosCarga.Show();
                }
                else
                {
                    MessageBox.Show("no hay filas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertarPrestamo()
        {
            try
            {
                if (this.dataGridSocios.CurrentRow != null)
                {
                    //Socios socio = new Socios();

                    //socio.Nombre = this.dataGridSocios.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
                    //socio.Dni = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["Dni"].Value);
                    //socio.Apellido = this.dataGridSocios.CurrentRow.Cells["Apellido"].Value?.ToString() ?? "";
                    //socio.Direccion = this.dataGridSocios.CurrentRow.Cells["Direccion"].Value?.ToString() ?? "";
                    //socio.Email = this.dataGridSocios.CurrentRow.Cells["Email"].Value?.ToString() ?? "";
                    //socio.IdLocalidad = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["IdLocalidad"].Value);
                    //socio.IdSocio = Convert.ToInt32(this.dataGridSocios.CurrentRow.Cells["IdSocio"].Value);

                    //MessageBox.Show($"nombre seleccionado: {socio.Nombre}");

                    Form sociosCarga = new frmSociosCarga(1, this);
                    sociosCarga.Show();
                }
                else
                {
                    MessageBox.Show("no hay filas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prestamoCarga prestamos = new prestamoCarga();
            prestamos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVentaCarga ventaCarga = new frmVentaCarga();
            ventaCarga.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertarPrestamo();
            mostrarSocios();
        }
    }
}
