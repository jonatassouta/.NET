using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11___Preencher_os_valores_do_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int valor;
            int posicao;

            Console.WriteLine("Lembre-se o Vetor tem apenas 10 posiçoes, e começa na posição 0");
            Console.ReadKey();

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Informa um valor: ");
                    valor = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme a posição que deseja guardar: ");
                    posicao = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("O caracter informado deve ser um numero inteiro.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    num[posicao] = valor;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\n\nA posição informa excede o tamanho do vetor,\n " +
                        "LEMBRE-SE O VETOR POSSUE APENAS 10 POSIÇOES E COMEÇA NA POSIÇÃO 0\n" +
                        "PORTANTO AS POSIÇOES SÃO DE 0 A 9");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                foreach (int s in num)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar");

                Console.ReadKey();
            }    
        }
    }
}
