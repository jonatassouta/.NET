using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados obrigatórios

            Console.Write("Qual o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Qual o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Qual o numero da agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            //Fim da entrada de dados obrigatórios

            ContaCorrente p1 = new ContaCorrente(nome, numeroConta, numeroAgencia);
            ContaPoupança p2 = new ContaPoupança(nome, numeroConta, numeroAgencia);


            p1.TotalDeContas();
            Console.ReadLine();

            //p2.Autenticar("Musica");
            //Conta Corrente

            Console.Write("\n\n----------Dados Conta Corrente----------\n\n");

            p1.ExibirDados();
            Console.ReadKey();

            p1.Depositar(p1.ValorDeposito);
            Console.ReadKey();

            p1.Sacar(p1.valorSaque);
            Console.ReadKey();

            p1.PagarConta();
            p1.ExibirDados();
            Console.ReadKey();

            //Conta Poupança

            Console.Write("\n\n----------Dados Conta poupança----------\n\n");

            p2.ExibirDados();
            Console.ReadKey();

            p2.Rendimento();
            p2.ExibirDados();
            Console.ReadKey();

            //Transferencia Entre Contas

            Console.Write("\n\n------Tranferncia Corrente/Popança-----\n\n");

            //Dados Conta Corrente
            
            p1.Transferencia(p2, p1);
            p1.ExibirDados();
            Console.ReadKey();

            //Dados Conta Poupança

            Console.Write("\n\n----------Dados Conta Poupança----------\n\n");

            p2.ExibirDados();
            Console.ReadKey();

            //--------------------------------------------------

           
        }
    }
}
