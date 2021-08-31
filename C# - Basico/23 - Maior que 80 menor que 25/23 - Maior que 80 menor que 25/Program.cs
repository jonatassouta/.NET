using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Maior_que_80_menor_que_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "";
            double n;
            do
            {
                Console.Write("Informe um numero: ");
                n = double.Parse(Console.ReadLine());

                if (n > 80)
                {
                    Console.Write("Este numero é maior que 80\n\n");
                }
                else if (n < 25)
                {
                    Console.Write("Este numero é menor que 25\n\n");
                }
                else if (n == 40)
                {
                    Console.Write("Este numero é igual 40\n\n");
                }

                Console.Write("Gostaria de continuar (s) ou (n): ");
                opc = Console.ReadLine();
            } while (opc == "s");

            Console.ReadKey();
        }
    }
}
