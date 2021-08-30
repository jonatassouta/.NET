using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, maior=0, menor=0;

            Console.Write("Informe o primeiro numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro numero 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro numero 3: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro numero 4: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4)
            {
                maior = n2;
            }
           
            else if (n3 > n2 && n3 > n1 && n3 > n4)
            {
                maior = n3;
            }
         

            else if (n4 > n2 && n4 > n3 && n4 > n1)
            {
                maior = n4;
            }


            if (n1 < n2 && n1 < n3 && n1 < n4)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3 && n2 < n4)
            {
                menor = n2;
            }

            else if (n3 < n2 && n3 < n1 && n3 < n4)
            {
                menor = n3;
            }


            else if (n4 < n2 && n4 < n3 && n4 < n1)
            {
                menor = n4;
            }


            Console.Write("\n \n o maior valor é: {0} \nO menor valor é: {1}", maior, menor);
            Console.ReadKey();
        }
    }
}
