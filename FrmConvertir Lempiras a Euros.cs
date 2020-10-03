﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_de_Navegacio.Formularios
{
    public partial class FrmConvertir_de_Lempiras_a_Euros : Form
    {
        public FrmConvertir_de_Lempiras_a_Euros()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (txtLempiras.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad en Lempiras Para Convertirlos a Euros.");
                txtLempiras.Focus();
                return;
            }

            double lemp, res;

            lemp = Convert.ToDouble(txtLempiras.Text);

            res = lemp * 0.035;

            txtResultado.Text = res.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLempiras_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtLempiras.Text = "";
            txtResultado.Text = "";

            txtLempiras.Focus();
        }
    }
}
