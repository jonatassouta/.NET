using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroAgencia { get; private set; }
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numeroAgencia, int numeroConta, string titular, double saldo)
        {
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            Saldo -= valorSaque;
        }

        public override string ToString()
        {
            return "\nTitular: " + Titular + "\nNumero da conta: " + NumeroConta + "\nAgência: " + NumeroAgencia + "\nSaldo: R$" + Saldo.ToString("F2");
        }
    }
}
