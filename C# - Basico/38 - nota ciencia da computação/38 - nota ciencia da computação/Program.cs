using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38___nota_ciencia_da_computação
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            Console.WriteLine("Digite a nota do laboratorio, da avaliação semestral e do exame final, respectivamente: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            media = ((a * 2) + (b * 3) + (c * 5)) / 6;

            Console.WriteLine("A média ponderada é de : " + media);

            Console.ReadKey();
        }
    }
}
