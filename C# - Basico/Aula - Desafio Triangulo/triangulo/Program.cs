using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            var linha = 10;
            var coluna = 1;

            for (int i = 0; i < linha; i++)
            {
                coluna = i;
                Console.Write(i + " ");
                for (int j = 2; j <= coluna; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
