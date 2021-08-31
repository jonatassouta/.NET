using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36___Conta_de_luz
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo_cliente;
            double valor_kwh, conta;

            Console.Write("Qual tipo de cliente você pertence: Residência (1), Comercio (2), Industria (3): ");
            tipo_cliente = int.Parse(Console.ReadLine());

            Console.Write("Quantos KW/H foram gastos este mês? ");
            valor_kwh = int.Parse(Console.ReadLine());

            if (tipo_cliente == 1)
            {
                conta = valor_kwh * 0.60;
                Console.WriteLine("\t\nSua conta de luz este mês é de : R$ " + conta);
            }
            else if (tipo_cliente == 2)
            {
                conta = valor_kwh * 0.48;
                Console.WriteLine("\t\nSua conta de luz este mês é de : R$ " + conta);
            }
            else if (tipo_cliente == 3)
            {
                conta = valor_kwh * 1.29;
                Console.WriteLine("\t\nSua conta de luz este mês é de : R$ " + conta);
            }

            Console.ReadKey();
        }
    }
}
