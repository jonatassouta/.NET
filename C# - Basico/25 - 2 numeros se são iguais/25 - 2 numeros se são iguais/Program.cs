using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___2_numeros_se_são_iguais
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0;

            Console.Write("Escreve um numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Escreve um numero: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.Write("\nEsses numeros são iguais.");
            }
            else
            {
                Console.Write("\nEsses numeros são diferentes.");

                if (n1 > n2)
                {
                    Console.Write($"\nO numero {n1} é maior que {n2}");
                }
                else
                {
                    Console.Write($"\nO numero {n2} é maior que {n1}");
                }
            }

            Console.ReadKey();
        }
    }
}
