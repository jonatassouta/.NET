using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Banco
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, int numeroConta, int numeroAgencia) : base(nome, numeroConta, numeroAgencia)
        {
           
        }
     
        public void Transferencia(Conta recebe, ContaCorrente envia)
        {
            double valorTransferencia;

            Console.WriteLine("\n\nQual o valor da transferencia: ");
            valorTransferencia = double.Parse(Console.ReadLine());

            if (valorTransferencia > envia.Saldo)
            {
                Console.WriteLine("\n\n\tSaldo insuficiente!");
            }
            else
            {
                recebe.Saldo += valorTransferencia;
                envia.Saldo -= valorTransferencia;
            }
            
        }
    }
}