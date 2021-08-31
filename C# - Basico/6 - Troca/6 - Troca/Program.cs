using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Troca
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, trocab;

            Console.WriteLine("Informe um numero para A:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero para B:");
            b = double.Parse(Console.ReadLine());

            trocab = a;
            a = b;
            b = trocab;

            Console.WriteLine("Os valores dos numeros trocados são: \n A: {0} \n B: {1} ", a, b);
            Console.ReadKey();
        }
    }
}
