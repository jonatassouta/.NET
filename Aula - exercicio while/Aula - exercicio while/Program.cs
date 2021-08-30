using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___exercicio_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabuado: Usuario digita um numero e é imprimido a tabuada.
            int n = 0, tabuada;
            int x = 0;//variavel do while

            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("---------------------Com FOR---------------------------\n\n");

            for (int i = 0; i <= 10; i++)
            {
                tabuada = n * i;
                Console.Write("{0} x {1} = {2} \n", n, i, tabuada);
            }

            Console.Write("\n---------------------Com While-------------------------\n\n");

            while (x <= 10)
            {
                tabuada = n * x;
                Console.Write("{0} x {1} = {2} \n", n, x, tabuada);
                x++;
            }

            //hahaha nunca foi tão facil :D
            Console.ReadKey();
        }
    }
}
