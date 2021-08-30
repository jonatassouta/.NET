using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Desafio_2_imprimir_os_caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Marcoratti.net");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }



            Console.ReadKey();
        }
    }
}
