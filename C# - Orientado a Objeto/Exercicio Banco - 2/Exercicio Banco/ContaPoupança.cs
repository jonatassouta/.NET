using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco
{
    public class ContaPoupança : Conta// IAutentica //inAVEGAR É UM MÉTODO E NÃO UMA INTERFACE

    {
        public ContaPoupança(string nome, int numeroConta, int numeroAgencia) : base(nome, numeroConta, numeroAgencia)
        {
           
        }

        public void Rendimento()
        {
            Console.Write("\nO rendimento da sua conta poupança é de: ");

            Saldo += (Saldo * 0.05);
        }

       /* public bool Autenticar(string senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Entroouuu");
                return true;
            }
            else
            {
                Console.WriteLine("Não está certo");
                return false;
            }

           
        }*/
    }
}
