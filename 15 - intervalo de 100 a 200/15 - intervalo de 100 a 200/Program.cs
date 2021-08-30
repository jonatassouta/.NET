using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___intervalo_de_100_a_200
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.Write("Informe um numero: ");
            a = double.Parse(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                Console.Write($"O numero {a} esta entre 100 e 200");
            }
            else
            {
                Console.Write($"O numero {a} nao esta no intervalo entre 100 e 200");
            }

            Console.ReadKey();
        }
    }
}
