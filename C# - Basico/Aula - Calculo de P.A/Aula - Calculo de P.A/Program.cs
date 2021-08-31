using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Calculo_de_P.A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo da P.A
            //A1, // Primeiro termo da Progressão Aritmética AN, 
            // Enésimo termo da Progressão Aritmética N, // Número de elementos de Progressão Aritmética R, 
            // Razão da Progressão Aritmética CONT; // Contador
            //AN = (A1 + ((N - 1) * R));

            double A1, R, N = 0, AN = 0;
            double x = 0 , y = 0, an = 0, Nn = 0, t;

            Console.Write("Qual o valor do primeiro termo (A1): ");
            A1 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor da razão da P.A (R): ");
            R = double.Parse(Console.ReadLine());

            Console.Write("Quantos termos tem a P.A (N): ");
            N = double.Parse(Console.ReadLine());

            Console.Write("\n\n---------------------Com For----------------------\n\n");

            for (int i = 1; i <= N; i++)
            {
                t = (A1 + ((i - 1) * R));

                Console.Write($"A{i} = {t} \n");

                AN = (A1 + ((i - 1) * R));               
            }

            Console.Write("\n\nO valor de AN é: " + AN);

            Console.Write("\n\n---------------------Com while----------------------\n\n");

            while ( x < N)
            { 
                an = (A1 + ((N - 1) * R));
                x++;
            }

            Console.Write("O valor de AN é: "+ an);

            Console.Write("\n\n---------------------Com do while----------------------\n\n");

            do
            {
                Nn = (A1 + ((N - 1) * R));
                y++;
            }
            while (y < N);

            Console.Write("O valor de AN é: " + Nn);

            Console.ReadKey();
           
        }
    }
}
