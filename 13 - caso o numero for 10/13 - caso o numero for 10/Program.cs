using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___caso_o_numero_for_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.Write("Informe um número, se ele for maior que 10 será imprimido: ");
            n = double.Parse(Console.ReadLine());
            
            if ( n > 10)
            {
                Console.Write($"O numero {n} é maior que 10");
            }
            else
            {
                Console.Write("O numero informado não é maior que 10");
            }

            Console.ReadKey();
        }
    }
}
