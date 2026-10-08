using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class prestamoCarga : Form
    {
        public prestamoCarga()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void prestamoCarga_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
            labelDEsde.Visible = false;
            labelHasta.Visible = false;
            button1.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            }else{
                    labelDEsde.Visible = true;
                    labelHasta.Visible = true;
                    button1.Visible = true;
                    textBox1.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;

            } 

        }
    }
}
