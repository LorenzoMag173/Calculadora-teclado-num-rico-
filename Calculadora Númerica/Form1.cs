using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Númerica
{
    public partial class Calculadora : Form
    {
        model modelo;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
              
        }

        private void num1_Click(object sender, EventArgs e)
        {
           
        }

        private void num2_Click(object sender, EventArgs e)
        {
            
        }

        private void num3_Click(object sender, EventArgs e)
        {

        }

        private void num4_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void num6_Click(object sender, EventArgs e)
        {

        }

        private void num7_Click(object sender, EventArgs e)
        {

        }

        private void num8_Click(object sender, EventArgs e)
        {

        }

        private void num9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //virgula 

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void adição_Click(object sender, EventArgs e)
        {
            if (numUm.Text == "" || numDois.Text == "")
            {
                igual.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numUm.Text);
                int num2 = Convert.ToInt32(numDois.Text);
                igual.Text = "";
                igual.Text = "" + modelo.subtrair(num1, num2);
            }

        }//fim do soma 

        private void subtração_Click(object sender, EventArgs e)
        {

            if (numUm.Text == "" || numDois.Text == "")
            {
                igual.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numUm.Text);
                int num2 = Convert.ToInt32(numDois.Text);
                igual.Text = "" + modelo.subtrair(num1, num2);
            }
        }//fim do subtração

        private void multiplicação_Click(object sender, EventArgs e)
        {
            if (numUm.Text == "" || numDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numUm.Text);
                int num2 = Convert.ToInt32(numDois.Text);
                igual.Text = "" + modelo.multiplicar(num1, num2);
            }

        }//fim do multiplicação

        private void divisão_Click(object sender, EventArgs e)
        {
            if (numUm.Text == "" || numDois.Text == "")
            {
                igual.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numUm.Text);
                int num2 = Convert.ToInt32(numDois.Text);
                igual.Text = "" + modelo.dividir(num1, num2);

                if (modelo.dividir(num1, num2) == -1)
                {
                    igual.Text = "Impossivel Dividir";
                }
                else
                {
                    igual.Text = "" + modelo.dividir(num1, num2);
                }
            }
        }//fim do divisão

        private void apagar_Click(object sender, EventArgs e)
        {
            if (numUm.Text == "" || numDois.Text == "")
            {
                igual.Text = "Preencha os campos númericos";
            }
            else
            {
                numUm.Text = "";
                numDois.Text = "";
                resultado.Text = "";
            }
        }//fim do apagar

        private void resposta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
