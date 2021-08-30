using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Ler_numero_de_1_a_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // n2, n3, n4, n5
            int[] n1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("informe os numeros de 1 a 5");
                n1[i] = int.Parse(Console.ReadLine());

                Console.Write("\n");

                if (n1[i] < 1)
                {
                    Console.WriteLine($"O numero {n1[i]} esta incorreto. POR FAVOR DIGITE OUTRO \n");
                    i--;
                }
                else if(n1[i] > 5)
                {
                    Console.WriteLine($"O numero {n1[i]} esta incorreto. POR FAVOR DIGITE OUTRO \n");
                    i--;
                }
            }

            foreach (int numeros in n1)
            {
                Console.WriteLine(numeros);
            }

            Console.ReadKey();
        }
    }
}
