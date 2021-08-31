using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Media_Aluno
{
    class media
    {
        static void Main(string[] args)
        {
            double a, b, c, r;

            Console.WriteLine("Informe a nota de Ciências:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota de Matematica:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota de Biologia:");
            c = double.Parse(Console.ReadLine());

            r = (a + b + c) / 3;

            Console.WriteLine("A média é: " + r);
            Console.ReadKey();
        }
    }
}
