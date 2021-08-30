using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___3_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, n1, n2;
            double r = 0;
            char c;

            Console.WriteLine("Infome um operado matematico: Ex: +, - ...");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("Infome 2 numeros ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (c == '+')
              {
                r = n1 + n2;
              }
              else if (c == '-')
              {
                r = n1 - n2;
              }
              else if (c == '*')
              {
                r = n1 * n2;
              }
              else if (c == '/')
              {
                try
                {
                    r = n1 / n2;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Não tem como dividir {0} por zero.", n1);
                }
            }
              else
              {
                 Console.WriteLine("\n\n\tOperador Invalido");
              }

            if (n2 == 0)
            {
                Console.WriteLine("\n\n\tOperador Invalido");
            }
            i++;

            Console.WriteLine("\n\n\t(" + c + ") = " + r);
            Console.ReadKey();
        }
    }
}
