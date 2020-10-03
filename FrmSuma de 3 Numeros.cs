using System;
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
    public partial class FrmSuma_de_3_Numeros : Form
    {
        public FrmSuma_de_3_Numeros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtPrimervalor.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingresar los Datos Para Relizar la Suma.");
                txtPrimervalor.Focus();
                return;
            }

            double vl1, vl2, vl3, res;

            vl1 = Convert.ToDouble(txtPrimervalor.Text);
            vl2 = Convert.ToDouble(txtSegundovalor.Text);
            vl3 = Convert.ToDouble(txtTercervalor.Text);

            res = vl1 + vl2 + vl3;

            txtResultado.Text = res.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimervalor.Text = "";
            txtSegundovalor.Text = "";
            txtTercervalor.Text = "";
            txtResultado.Text = "";

            txtPrimervalor.Focus();
        }
    }
}
