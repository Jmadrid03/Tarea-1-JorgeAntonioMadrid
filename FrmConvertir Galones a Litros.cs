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
    public partial class FrmConvertir_Galones_a_Litros : Form
    {
        public FrmConvertir_Galones_a_Litros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (txtGalones.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Cantidad en Galones Para Convertirlos a Litros.");
                txtGalones.Focus();
                return;
            }

            double gal, res;

            gal = Convert.ToDouble(txtGalones.Text);

            res = gal * 3.785;

            txtResultado.Text = res.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtGalones.Text = "";
            txtResultado.Text = "";

            txtGalones.Focus();
        }
    }
}
