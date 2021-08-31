using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___ler_e_somar_arra___menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[] numeros = new int [5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero : ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] < 10)
                {
                    soma += numeros[i];
                }
            }

            Console.Write("A soma dos numeros menor que 10 é : " + soma);


            Console.ReadKey();
        }
    }
}
