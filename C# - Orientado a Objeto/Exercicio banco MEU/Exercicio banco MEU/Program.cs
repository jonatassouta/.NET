using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_banco_MEU
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\t\t\t\t\t----------CONTA BANCARIA----------\n\n");
            
            //Informando valores para o metodo constritor
            Console.Write("\t\t\t\t\tInforme a conta do Titular: ");
            string titular = Console.ReadLine();

            Console.Write("\t\t\t\t\tInforme o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("\t\t\t\t\tInforme o numero da agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());


            //Instaciando a clase 
            Conta p1 = new Conta(titular, numeroConta, numeroAgencia);

            //string para impresão dos dados d conta
            string dados = $"\n\n\t\t\t\t\tTitular: { titular} \n\t\t\t\t\tNumero d Agencias: { numeroAgencia}" +
                $" \n\t\t\t\t\tNumero da Conta: {numeroConta} \n\t\t\t\t\tSaldo: {p1.Saldo}";

            Console.Write(dados);
            Console.ReadKey();

            //DEPOSITO DECLARANDO OS VALORES  AQUI NO PROGRAM MESMO, MAS TEM COMO DECLARAR DIRETO NO METODO, FICA MAIS ORGANIZADO O PROGRAM
            Console.WriteLine("\n\n\t\t\t\t\tVocê deseja depositar quantos? ");
            double valorDeposito = double.Parse(Console.ReadLine());

            //chamando o metodo Depositar
            p1.Depositar(valorDeposito);


            Console.WriteLine("\n\t\t\t\t\tDados atualizados: \n");
            Console.WriteLine(dados);
            Console.ReadKey();


            //Chamando o método UsarChequeEsp
            p1.UsarChequeEsp();
            Console.ReadKey();
        }
    }
}


