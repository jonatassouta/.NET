using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Idade___com_orientação
{
    public class Pessoa
    {
        private int anoNacimento;

        public int AnoNascimento
        {
            get { return this.anoNacimento; }
            set { this.anoNacimento = value; }
        }

        //propfull tab tab

        private string nome;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private double peso;

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        private string opc;

        public string OPC
        {
            get { return this.opc; }
            set { this.opc = value; }
        }

        private double altura;

        public double Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }

        public void ExibirDados()
        {          
            int Idade = this.CalcularIdade();
            
            if (OPC == "S")
            {
                ClassificacaoIMC();
            }
            else
            {
                Console.Write("\n\n\t\t\t\t\tNome: " + this.nome);
                Console.Write("\n\t\t\t\t\tAno de Nascimento: " + this.anoNacimento);

                //Métodos

                Console.Write("\n\t\t\t\t\tIdade: " + Idade);
            }  
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int Idade = ano - anoNacimento;

            return Idade;
        }

        public void ClassificacaoIMC()
        {
            int Idade = this.CalcularIdade();
            double IMC = this.CalcularImc();

            //Dados informados
            Console.WriteLine("\t\t\t\t\tNome: " + this.nome);
            Console.WriteLine("\t\t\t\t\tAno de Nascimento: " + this.anoNacimento);
            Console.WriteLine("\t\t\t\t\tPeso: " + this.peso);
            Console.WriteLine("\t\t\t\t\tAltura: " + this.altura);

            //MÉTODOS
            Console.WriteLine("\n\n\t\t\t\t\tIdade: " + Idade);

            if (IMC < 18.5)
            {
                Console.Write($"\n\t\t\t\t\tSeu IMC é {IMC}. Você esta abaixo do peso, CUIDADO!!");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.Write($"\n\t\t\t\t\tSeu IMC é {IMC}. Você esta no seu peso ideal, PARABEMS!!");
            }
            else if (IMC >= 25 && IMC <= 29.5)
            {
                Console.Write($"\t\t\t\t\t\nSeu IMC é {IMC}. Você esta sobrepeso, ATENÇÃO!!");
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                Console.Write($"\t\t\t\t\t\nSeu IMC é {IMC}. OBESIDADE GRAU 1 CUIDADO!!!!");
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                Console.Write($"\t\t\t\t\t\nSeu IMC é {IMC}. OBESIDADE SEVERA CUIDADO!!!!");
            }
            else if (IMC >= 40)
            {
                Console.Write($"\t\t\t\t\t\nSeu IMC é {IMC}. OBESIDADE MÓRBIDA CUIDADO!!!!");
            }
        }
        
        private double CalcularImc()
        {
            double IMC;

            Console.Write("\n\n\t\t\t\t\t--------------Calculo IMC------------\n\n ");

            Console.Write("\t\t\t\t\tDigite o seu peso: ");
            this.Peso = double.Parse(Console.ReadLine());

            Console.Write("\t\t\t\t\tDigite a sua altura: ");
            this.Altura = double.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            return IMC;
        }
    }
}
