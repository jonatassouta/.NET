using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___receba_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Informe um numero: ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.Write("Este numero é positivo.\n\n");
                }
                else if (n < 0)
                {
                    Console.Write("Este numero é negativo.\n\n");
                }
                else if (n == 0)
                {
                    Console.Write("Este numero é zero.\n\n");
                }
            } while (true);

            Console.ReadKey();
        }
    }
}
