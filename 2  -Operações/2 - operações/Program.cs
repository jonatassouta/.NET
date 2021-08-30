using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___operações
{
    class Operacoes
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Informe valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Soma: {0} \n Subtração: {1} \n Multiplicação: {2} \n Divizão: {3}" , (a + b), (a - b), (a * b), (a / b));
            Console.ReadKey();
        }
    }
}
