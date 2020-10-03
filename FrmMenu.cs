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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma_de_3_Numeros Suma = new Formularios.FrmSuma_de_3_Numeros();
            Suma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalificaciones_de_Estudiantes Estudiantes = new Formularios.FrmCalificaciones_de_Estudiantes();
            Estudiantes.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMillasaMetros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Metros_a_Millas Millas = new Formularios.FrmConvertir_Metros_a_Millas();
            Millas.Show();
        }

        private void BtnMillasaKilometros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Millas_a_Kilometros Kilometros = new Formularios.FrmConvertir_Millas_a_Kilometros();
            Kilometros.Show();
        }

        private void BtnLempirasaDolares_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Lempiras_a_Dolares Lempiras = new FrmConvertir_Lempiras_a_Dolares();
            Lempiras.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_de_Lempiras_a_Euros euros = new FrmConvertir_de_Lempiras_a_Euros();
            euros.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Galones_a_Litros Galones = new FrmConvertir_Galones_a_Litros();
            Galones.Show();

        }

        private void BtnComprallantas_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalculat_el_Total_a_Pagar_de_la_Compra_de_Llantas Llantas = new FrmCalculat_el_Total_a_Pagar_de_la_Compra_de_Llantas();
            Llantas.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_Dias Diast = new FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_Dias();
            Diast.Show();
        }

        private void BtnSalarioDiasH_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_dias_y_horas_Trabajadas Horas = new FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_dias_y_horas_Trabajadas();
            Horas.Show();
        }
    }
}
