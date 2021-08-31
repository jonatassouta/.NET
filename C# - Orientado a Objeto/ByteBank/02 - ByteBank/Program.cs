using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaJeniffer = new ContaCorrente();

            contaDaJeniffer.tituar = "Jeniffer";
           
            Console.WriteLine("Titular: " + contaDaJeniffer.tituar);
            Console.WriteLine("Saldo: " + contaDaJeniffer.saldo);

            Console.ReadLine();
        }
    }
}
