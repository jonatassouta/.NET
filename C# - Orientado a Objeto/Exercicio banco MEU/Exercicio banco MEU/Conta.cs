using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_banco_MEU
{
    class Conta
    {
        public int NumeroAgencia { get;  set; }
        public int NumeroConta { get;  set; }
        public string Titular { get;  set; }
        public double Saldo { get;  set; }
        public double ChequeEsp { get; set; }

        public Conta(string titular, int numeroConta, int numeroAgencia)
        {
            Titular = titular;
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
        }

        public void Depositar(double valorDeposito)
        {         
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            Console.WriteLine("\n\t\t\t\t\tValor do Saque: ");
            valorSaque = double.Parse(Console.ReadLine());

            if (valorSaque < Saldo)
            {
                Saldo -= valorSaque;
            }

            Console.Write(Saldo);
        }

        public void UsarChequeEsp()
        {
            string pergunta;

            Console.WriteLine("\n\t\t\t\t\tDeseja cheque especial? sim ou nao");
            pergunta = Console.ReadLine();
            pergunta.ToUpper();//CONVERT TUDO PARA MAIUSCULA

            ChequeEsp = 1000;

            if (pergunta == "SIM")
            {
                Saldo += ChequeEsp;
            }
            else
            {
                Console.Write("\n\t\t\t\t\tVocê não solicitou o cheque especial");
            }
        }
    }
}
