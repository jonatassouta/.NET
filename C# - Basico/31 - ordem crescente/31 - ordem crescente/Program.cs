using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 ,meio = 0, maior = 0, menor = 0, i = 0;

            while (i <= 2)
            {

                Console.Write("Escreva 3 numeros distintos " + (i + 1) + ": ");
                n1 = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = n1;
                    meio = n1;
                    menor = n1;
                }


                if (n1 > maior)
                {
                    maior = n1;
                }
                if (n1 < menor)
                {
                    menor = n1;
                }
                if (n1 > menor && n1 < maior)
                {
                    meio = n1;
                }
                i++;
            }
            Console.WriteLine(menor + ", " + meio + ", " + maior);

            Console.ReadKey();
        }
    }
}
