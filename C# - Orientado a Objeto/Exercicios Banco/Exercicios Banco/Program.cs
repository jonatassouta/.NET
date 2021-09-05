using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("__________CONTA BANCÁRIA__________");



                Console.Write("\nInforme o nome do titular: ");
                string titular = Console.ReadLine();



                Console.Write("Informe o número da agência: ");
                int numeroAgencia = int.Parse(Console.ReadLine());



                Console.Write("Informe o número da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());



                Console.Write("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());



                Conta conta = new Conta(numeroAgencia, numeroConta, titular, saldo);



                Console.WriteLine(conta);
                Console.ReadKey();



                Console.Write("\nInforme um valor para depositar: R$");
                double valorDeposito = double.Parse(Console.ReadLine());



                conta.Depositar(valorDeposito);



                Console.WriteLine("\nDados atualizados:");
                Console.WriteLine(conta);
                Console.ReadKey();



                Console.Write("\nInforme um valor para sacar: R$");
                double valorSaque = double.Parse(Console.ReadLine());



                conta.Sacar(valorSaque);



                Console.WriteLine("\nDados atualizados:");
                Console.WriteLine(conta);

                Console.ReadKey();
            }
        }
    }
