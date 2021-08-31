using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___informar_um_numeor_e_falar_cada_numero_separado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            int num, // Número a ser fornecido pelo usuário
            d1, d2, d3, d4; // Dígitos a serem extraídos do número fornecido pelo usuário

            // Solicita e lê um número de 4 dígitos
            Console.Write("\nInforme o Número: ");
            num = Int32.Parse(Console.ReadLine());

            // Extrai os 4 dígitos do número fornecido
            d1 = (num / 1000) % 10;
            d2 = (num / 100) % 10;
            d3 = (num / 10) % 10;
            d4 = (num % 10);

            // Exibe o número
            Console.WriteLine("\nO número fornecido é: \n" + d1 + " milhares\n" + d2 + " centenas\n" + d3 + " dezenas\n" + d4 + " unidades\n\n");

            Console.ReadKey();


            string num;
            int i = 1;

            Console.WriteLine("Digite um numero para saber quantidade de digitos: ");
            num = Console.ReadLine();
            foreach (var item in num)
            {

                Console.WriteLine(" O  " + i++ + "° numero e: " + item);

            }

            Console.ReadKey();



            Console.Write("Digite um número de quatro dígitos: ");
            string s = Console.ReadLine();

            var n = s.ToCharArray();

            foreach (char num in n)
            {
                Console.WriteLine("\n" + num);
            }

            Console.ReadKey();
        }
    }
}
