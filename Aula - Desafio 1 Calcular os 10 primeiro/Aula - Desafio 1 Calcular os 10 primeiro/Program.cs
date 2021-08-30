using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Desafio_1_Calcular_os_10_primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula os 10 primeiros termos da série: (2/500) - (5/450) + (2/400) - (5/350)...
            int i, x = 500;

            Console.Write("Calcula os 10 primeiros termos da série: (2/500) - (5/450) + (2/400) - (5/350)...\n \n");

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}: (5 / {x}) +", x);
                }
                else if(i % 2 == 1)
                {
                    Console.WriteLine($"{i}: (2 / {x}) -", x);
                }              

                x -= 50;   
            }
           
            Console.ReadKey();
        }
    }
}
