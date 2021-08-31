using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___ler_80_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;

            for (int i = 1; i <= 80; i++)
            {

                Console.Write($"Digite 80 numeros aleatorios, numero {i}: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 150)
                {
                    soma++;

                }
               
            }

            Console.Write($"Foram digitados {soma} números no intervalo entre 10 e 150.");

            Console.ReadKey();
        }
    }
}
