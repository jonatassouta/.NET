using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Custo_do_carro
{
    class Program
    {
        static void Main(string[] args)
        {
            double custo_fabrica, consumo, porc_distribuidor = 0.28;
            const double imposto = 0.45;

            Console.Write("Qual o custo de frabrica do carro? ");
            custo_fabrica = double.Parse(Console.ReadLine());

            custo_fabrica += (custo_fabrica * imposto);
            consumo = custo_fabrica + (porc_distribuidor * custo_fabrica);

            Console.Write("O custo do carro é: " + consumo);
            Console.ReadKey();
        }
    }
}
