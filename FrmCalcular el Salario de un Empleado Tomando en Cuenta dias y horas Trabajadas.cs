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
    public partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_dias_y_horas_Trabajadas : Form
    {
        public FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_dias_y_horas_Trabajadas()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDiast.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar los Datos Para Calcular el Salario.");
                TxtDiast.Focus();
                return;
            }

            double dt, hrt, vlrd, vlrh, res;

            dt = Convert.ToDouble(TxtDiast.Text);
            hrt = Convert.ToDouble(TxtHorast.Text);
            vlrd = Convert.ToDouble(TxtValord.Text);
            vlrh = Convert.ToDouble(TxtValorh.Text);

            res = (dt * vlrd) + (hrt * vlrh);

            TxtSalario.Text = res.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDiast.Text = "";
            TxtHorast.Text = "";
            TxtValord.Text = "";
            TxtValorh.Text = "";
            TxtSalario.Text = "";

            TxtDiast.Focus();
        }
    }
}
