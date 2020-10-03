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
    public partial class FrmConvertir_Metros_a_Millas : Form
    {
        public FrmConvertir_Metros_a_Millas()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (txtMillas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Millas Para Convertir a Metros.");
                txtMillas.Focus();
                return;
            }

            double millas, res;

            millas = Convert.ToDouble(txtMillas.Text);

            res = millas * 1609.34;

            txtResultado.Text = res.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtMillas.Text = "";
            txtResultado.Text = "";

            txtMillas.Focus();
        }
    }
}
