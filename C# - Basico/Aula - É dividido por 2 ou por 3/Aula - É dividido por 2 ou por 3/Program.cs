using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___É_dividido_por_2_ou_por_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.Write("Informe 4 numeros: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.Write($"\nO numero {a} é divisivel por 2 \n");
            }

            if (b % 2 == 0)
            {
                Console.Write($"O numero {b} é divisivel por 2 \n");
            }

            if (c % 2 == 0)
            {
                Console.Write($"O numero {c} é divisivel por 2 \n");
            }

            if (d % 2 == 0)
            {
                Console.Write($"O numero {d} é divisivel por 2 \n");
            }

           // ---------------------------------------------------------------------------------

             if (a % 3 == 0)
            {
                Console.Write($"O numero {a} é divisivel por 3 \n");
            }

            if (b % 3 == 0)
            {
                Console.Write($"O numero {b} é divisivel por 3 \n");
            }

            if (c % 3 == 0)
            {
                Console.Write($"O numero {c} é divisivel por 3 \n");
            }

            if (d % 3 == 0)
            {
                Console.Write($"O numero {d} é divisivel por 3 \n");
            }

            Console.ReadKey();
        }
    }
}
