
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulos___Autura__e_Largura
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura = 0;
            int altura = 0;

            Retangulo[] retangulo = new Retangulo[3];
            

            for (int i = 0; i < retangulo.Length; i++)
            {
                Console.Write($"Retangulo {i+1}/{retangulo.Length} ");

                Console.Write("\nInforme o valor da altura: ");
                altura = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor da largura: ");
                largura = int.Parse(Console.ReadLine());
                Console.Clear();

                Retangulo r1 = new Retangulo(altura, largura);

                retangulo[i] = r1;
            }

            Console.Write("\nAperte para continuar");
            Console.Clear();
            
            for (int i = 0; i < retangulo.Length; i++)
            {
                Console.Write("\nRetangulo: " + (i + 1));
                retangulo[i].Mostar();
            }


            Console.ReadKey();
        }
    }
}
