using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Ordenação_dos_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("...Ordenação dos numeros...");

            Console.Write("\nInforme 3 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.Write($"\n\nO numero {n1} é o maior");
            }else if (n1 < n2 && n1 < n3)
            {
                Console.Write($"\nO numero {n1} é o menor");
            }else
            {
                Console.Write($"\nO numero {n1} é o médio");
            }

            //-------------------------------------------------------------------

            if (n2 > n1 && n2 > n3)
            {
                Console.Write($"\nO numero {n2} é o maior");
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.Write($"\nO numero {n2} é o menor");
            }
            else
            {
                Console.Write($"\nO numero {n2} é o médio");
            }

            //-------------------------------------------------------------------

            if (n3 > n2 && n3 > n1)
            {
                Console.Write($"\nO numero {n3} é o maior");
            }
            else if (n3 < n2 && n3 < n1)
            {
                Console.Write($"\nO numero {n3} é o menor");
            }
            else
            {
                Console.Write($"\nO numero {n3} é o médio");
            }

            Console.ReadKey();

        }
    }
}
