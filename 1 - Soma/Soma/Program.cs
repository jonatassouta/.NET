using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Soma
    {
        static void Main(string[] args)
        {
            double a, b, r;

            Console.Write("Inform o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Inform o valor de B: ");
            b = double.Parse(Console.ReadLine());

            r = a + b;

            Console.WriteLine("A som é: "+ r);
            Console.ReadKey();
        }
    }
}
