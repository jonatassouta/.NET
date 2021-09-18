using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1WForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso   = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                txtLabel.Text = "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                txtLabel.Text = "Peso Normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                txtLabel.Text = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 34.4)
            {
                txtLabel.Text = "Obesidade Grau 1";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                txtLabel.Text = "Obesidade Grau 2";
            }
            else if (imc >= 40)
            {
                txtLabel.Text = "Obesidade Morbida";
            }


            txtReultado.Text = imc.ToString("N2");
        }
    }
}
