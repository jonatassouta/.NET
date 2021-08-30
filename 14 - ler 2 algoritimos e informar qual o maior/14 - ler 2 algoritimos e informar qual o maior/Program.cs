using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___ler_2_algoritimos_e_informar_qual_o_maior
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Informe dois numeros: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.Write($"O numero {a} é o maior");
            }
            else
            {
                Console.Write($"O numero {b} é o maior");
            }

            Console.ReadKey();
        }
    }
}
