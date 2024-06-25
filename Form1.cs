using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            int peso = Int32.Parse(txt_peso.Text);
            float altura = float.Parse(txt_Altura.Text);

            float imc = peso / (altura * altura);

            lbl_imc.Text = imc.ToString();

            if (imc < 16){
                lbl_resultado.Text = "Magreza Grave";
            }
            else if (imc >= 16 && imc <= 16.9){
                lbl_resultado.Text = "Magreza Moderada";
            }
            else if (imc >= 17 && imc <= 18.5){
                lbl_resultado.Text = "Magreza Leve";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                lbl_resultado.Text = "Peso Ideal!";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lbl_resultado.Text = "Sobre Peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                lbl_resultado.Text = "Obesidade Grau I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                lbl_resultado.Text = "Obesidade Grau II ou severa";
            }
            else
            {
                lbl_resultado.Text = "Obesidade Grau III ou Morbida";
            }
        }

        private void peso_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
