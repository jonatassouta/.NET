using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___pretsçoes_sem_juros
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_compra, prestacao;

            Console.Write("Qual o valor do produto: ");
            valor_compra = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                prestacao = valor_compra / 5 ;
                Console.Write($"\n\nValor da {i} prestação: {prestacao} \n");
            }

            Console.ReadKey();
        }
    }
}
