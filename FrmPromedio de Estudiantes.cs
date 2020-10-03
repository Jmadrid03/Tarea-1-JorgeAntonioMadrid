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
    public partial class FrmCalificaciones_de_Estudiantes : Form
    {
        public FrmCalificaciones_de_Estudiantes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcularpromedio_Click(object sender, EventArgs e)
        {
            if (txtPrimeracalificacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar las Calificaciones para Calcular el Promedio.");
                txtPrimeracalificacion.Focus();
                return;
            }

            double cal1, cal2, cal3, cal4, prom;

            cal1 = Convert.ToDouble(txtPrimeracalificacion.Text);
            cal2 = Convert.ToDouble(txtSegundacalificacion.Text);
            cal3 = Convert.ToDouble(txtTerceracalificacion.Text);
            cal4 = Convert.ToDouble(txtCuartacalificacion.Text);

            prom = (cal1 + cal2 + cal3 + cal4) / 4;

            txtPromedio.Text = prom.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimeracalificacion.Text = "";
            txtSegundacalificacion.Text = "";
            txtTerceracalificacion.Text = "";
            txtCuartacalificacion.Text = "";
            txtPromedio.Text = "";

            txtPrimeracalificacion.Focus();
        }
    }
}
