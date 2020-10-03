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
    public partial class FrmCalculat_el_Total_a_Pagar_de_la_Compra_de_Llantas : Form
    {
        public FrmCalculat_el_Total_a_Pagar_de_la_Compra_de_Llantas()
        {
            InitializeComponent();
        }

        private void FrmCalculat_el_Total_a_Pagar_de_la_Compra_de_Llantas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLlantas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Datos Para Calcular el Total a Pagar.");
                txtLlantas.Focus();
                return;
            }

            double llan, prec, sub, impto, res;

            llan = Convert.ToDouble(txtLlantas.Text);
            prec = Convert.ToDouble(txtPrecio.Text);

            sub = llan * prec;

            impto = sub * 0.15;

            res = sub + impto;

            txtsubtotal.Text = sub.ToString();
            txtImpuesto.Text = impto.ToString();
            txtResultado.Text = res.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtLlantas.Text = "";
            txtPrecio.Text = "";
            txtsubtotal.Text = "";
            txtImpuesto.Text = "";
            txtResultado.Text = "";

            txtLlantas.Focus();
        }
    }
}
