using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___maio_idade_menor_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Informe as idades: ");
                idade[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < 4; i++)
            {
                if (idade[i] >= 18)
                {
                    Console.Write($"{idade[i]} = Maior de Idade\n");
                }
                else
                {
                    Console.Write($"{idade[i]} = Menor de Idade\n");
                }
            }
    
            Console.ReadKey();
        }
    }
}
