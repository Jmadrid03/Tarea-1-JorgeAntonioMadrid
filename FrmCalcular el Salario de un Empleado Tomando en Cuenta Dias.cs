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
    public partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_Dias : Form
    {
        public FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_Dias()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDiast.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Datos Para Calcular el Salario.");
                txtDiast.Focus();
                return;
            }

            double dt, vlrd, res;

            dt = Convert.ToDouble(txtDiast.Text);
            vlrd = Convert.ToDouble(txtValord.Text);

            res = dt * vlrd;

            txtSalario.Text = res.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtDiast.Text = "";
            txtValord.Text = "";
            txtSalario.Text = "";

            txtDiast.Focus();
           
        }
    }
}
