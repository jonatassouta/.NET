using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Informe o tamanho do lado A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do lado A: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do lado A: ");
            c = int.Parse(Console.ReadLine());
            
            if (a == b && a==c)
            {
                Console.Write("\n\tÉ um triangulo equilátero");
            }
            else if (a == b || a == c || c == b)
            {
                Console.Write("\n\tÉ um triangulo isóscele ");
            }
            else if (a != b && a != c && c != b)
            {
                Console.Write("\n\tÉ um triangulo escaleno ");
            }

            Console.ReadKey();
        }
    }
    
}
