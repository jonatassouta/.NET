using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_C___F
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Qual a temperatura em celsio:");
            C = double.Parse(Console.ReadLine());

            F = ((9 * C) + 160) / 5;

            Console.WriteLine("A temperatura em fahrenheit é: " + $"{F:0.00}");//Formatação com casas  decimais, no caso, apenas 2 casas decimais.

            Console.ReadKey();
        }
    }
}
