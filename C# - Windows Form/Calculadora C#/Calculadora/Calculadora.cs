using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calculadora : Form {
        double[] numeros = new double[2];
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "9";
        }
        private void btm1_Click_1(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "1";
            numeros[0] = 1;
        }

        private void btm2_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "2";
            numeros[1] = 2;
        }

        private void btm3_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btm4_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btm5_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btm6_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btm7_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btm8_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btmPonto_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btmMais_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture --> Converte o valor com as pontuaçoes...2.5 viraria 25 sem esse comando corretas do decimal, sem ele nao consegue fazer equaçoes com ponto

                textBox1.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }      
        }

        private void btmMenos_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture --> Converte o valor com as pontuaçoes...2.5 viraria 25 sem esse comando corretas do decimal, sem ele nao consegue fazer equaçoes com ponto

                textBox1.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void btmMul_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture --> Converte o valor com as pontuaçoes...2.5 viraria 25 sem esse comando corretas do decimal, sem ele nao consegue fazer equaçoes com ponto

                textBox1.Text = "";
                operacao = "MUL";
                lblOperacao.Text = "X";
            }
        }

        private void btmDivi_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture --> Converte o valor com as pontuaçoes...2.5 viraria 25 sem esse comando corretas do decimal, sem ele nao consegue fazer equaçoes com ponto

                textBox1.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
        }

        private void btmClean_Click(object sender, EventArgs e) {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btmIgual_Click(object sender, EventArgs e) {
            if (textBox1.Text != "") {
                valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA") {
                    textBox1.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUB") {
                    textBox1.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MUL") {
                    textBox1.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIV") {
                    try {
                        textBox1.Text = Convert.ToString(valor1 / valor2);
                    }
                    catch (System.DivideByZeroException x) {
                        MessageBox.Show(x.Message);
                    }
                }
            }           
        }
    }
}
