using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeMatematica
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        //Variaveis de cálculo
        int addend1, addend2, sub1, sub2, mult1, mult2, div1, div2;

        //Contador
        int timeLeft;
           

        public Form1()
        {
            InitializeComponent();
        }

        private void startQuiz_Click(object sender, EventArgs e)
        {
            startQuiz.Enabled = false;

            addend1 = randomizer.Next(50);
            addend2 = randomizer.Next(50);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            somar.Value = 0;

            sub1 = randomizer.Next(1, 101);
            sub2 = randomizer.Next(1, sub1);            

            subLeft.Text = sub1.ToString();
            subRight.Text = sub2.ToString();

            subtracao.Value = 0;

            mult1 = randomizer.Next(2, 11);
            mult2 = randomizer.Next(2, 11);

            multLeft.Text = mult1.ToString();
            multRigth.Text = mult2.ToString();

            multiplicacao.Value = 0;

            div2 = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            div1 = div2 * temporaryQuotient;

            divLeft.Text = div1.ToString();
            divRigth.Text = div2.ToString();

            divisao.Value = 0;

            timeLeft = 30;
            TimeLabel.Text = "30 segundos";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckaResposta())
            {
                timer1.Stop();
                MessageBox.Show("Parabéns vc Conseguiu!!", "Parabéns!!!!!");

                startQuiz.Enabled = true;
            }
            else if(timeLeft > 0)
            {
                timeLeft--;
                TimeLabel.Text = timeLeft + " segundos";
            }
            else
            {
                timer1.Stop();
                TimeLabel.Text = "O tempo acabou :(";

                MessageBox.Show("Você não conseguiu no tempo.", "Matemática é vida");
                somar.Value = addend1 + addend2;
                subtracao.Value = sub1 - sub2;
                multiplicacao.Value = mult1 * mult2;
                divisao.Value = div1 / div2;

                startQuiz.Enabled = true;
            }
        }

        private bool CheckaResposta()
        {
            if ((addend1 + addend2 == somar.Value)
                &&(sub1 - sub2 == subtracao.Value)
                &&(mult1 * mult2 == multiplicacao.Value)
                &&(div1 / div2 == divisao.Value))
            
                return true;
            else
            {
                return false;
            }
        }
    }
}
