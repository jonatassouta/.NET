using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8___Ler_um_numero_inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;

            do
            {
                try
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    num = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n" + ex.Message + "\n");
                }

            } while (num == null);

            Console.ReadKey();
        }
    }
}
