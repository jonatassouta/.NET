using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco
{
    abstract public class Conta
    {

        private string nome;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private int numeroConta;

        public int NumeroConta
        {
            get { return this.numeroConta; }
            set { this.numeroConta = value; }
        }

        private int numeroAgencia;

        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            set { numeroAgencia = value; }
        }

        private double saldo;

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        private double valorDeposito;

        public double ValorDeposito
        {
            get { return this.valorDeposito; }
            set { this.valorDeposito = value; }
        }

        public int valorSaque { get; set; }

        public string Senha { get; set; }

        // Método construtor
        public Conta(string nome, int numeroConta, int numeroAgencia)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Saldo = 200;
            Senha = "Musica";
        }

        //Métodos exibir dados

        public virtual void ExibirDados()
        {
            Console.WriteLine($"\n\nNome: {Nome}");
            Console.WriteLine($"Numero da Conta: {NumeroConta}");
            Console.WriteLine($"Nunero da Agencia: {NumeroAgencia}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        //Métodos

        public double Depositar(double ValorDeposito)
        {
            string opc = "";

            Console.WriteLine("\n\nDeseja realizar um deposito? S OU N. ");
            opc = Console.ReadLine();
            opc = opc.ToUpper();

            if (opc == "S")
            {
                Console.WriteLine("\n\nQual o valor do deposito: ");
                ValorDeposito = double.Parse(Console.ReadLine());

                Saldo += ValorDeposito;

                Console.Write($"\nDepósito realizado com sucesso. Seu saldo é de {Saldo}");
            }

            return Saldo;
        }

        public double Sacar(double valorSaque)
        {
            string opc1 = "";
            string opc = "";

            Console.WriteLine("\n\nDeseja realizar um saque? S OU N. ");
            opc = Console.ReadLine();
            opc = opc.ToUpper();

            do
            {
                if (opc == "S")
                {
                    Console.Write("\n\nQual o valor do saque: ");
                    valorSaque = double.Parse(Console.ReadLine());
                    if (valorSaque <= Saldo && valorSaque > 5)
                    {
                        Saldo -= valorSaque;

                        Console.Write($"\nSaque realizado com sucesso. Seu saldo é de {Saldo}");
                    }
                    else if (valorSaque < 5)
                    {
                        {
                            Console.Write($"\nValor minimo de saque é 5. Seu saldo é de {Saldo}");
                        }
                    }
                    else
                    {
                        Console.Write($"\nSaldo insuficiente. Seu saldo é de {Saldo}");
                    }
                }

                Console.WriteLine("\n\nDeseja realizar mais um saque? S OU N. ");
                opc1 = Console.ReadLine();
                opc1 = opc1.ToUpper(); 

            } while (opc1 == "S");

            return Saldo;
        }
    }
}
