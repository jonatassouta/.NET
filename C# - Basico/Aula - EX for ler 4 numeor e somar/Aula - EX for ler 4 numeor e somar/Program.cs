using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___EX_for_ler_4_numeor_e_somar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler 4 numeros e somar os par

            int n1, soma = 0;

            for (int i = 0; i < 4 ; i++)
            {
                Console.WriteLine("Digite o numero {0}: ", (1+i));
                n1 = int.Parse(Console.ReadLine());
                if (n1 % 2 == 0 )
                {
                    soma += n1;               
                }               
            }

            if (soma == 0)
            {
                Console.WriteLine("Nenhum número par digitado!");
            }

            else
            {
                Console.WriteLine("A soma dos números pares é = " + soma);
            }

            Console.ReadKey();
        }
    }
}
