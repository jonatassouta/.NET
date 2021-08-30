using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Média_aluno__e_aprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            Console.WriteLine("Qual a nota de Ciências: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota de Matematica: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota de Português: ");
            c = double.Parse(Console.ReadLine());

            media = (a + b + c) / 3;

            if (media >= 7)
            {
                Console.Write($"Sua média é {media} Você foi aprovado");
            }
            else if (media <= 5)
            {
                Console.Write($"Sua média é {media} Você foi reprovado");
            }
            else
            {
                Console.Write($"Sua média é {media} Você esta de recuperação");
            }

            Console.ReadKey();
        }
    }
}
