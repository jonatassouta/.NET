using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39____nota_e_classificação
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double a, b, c, media, ra;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("R.A: ");
            ra = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do laboratorio, da avaliação semestral e do exame final, respectivamente: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            media = ((a * 2) + (b * 3) + (c * 5)) / 6;


            if ( media > 8.10)
            {
                Console.Write("Classificação A");
            }
            else if (media >= 7.8 && media < 8.10)
            {
                Console.Write("Classificação B");
            }
            else if (media >= 6.7 && media < 7.8)
            {
                Console.Write("Classificação C");
            }
            else if (media >= 5.6 && media < 6.7)
            {
                Console.Write("Classificação D");
            }
            else if (media >= 0.5 && media < 5.6)
            {
                Console.Write("Classificação R");
            }

            Console.Write($"\nNome: {nome} \nNumero: {ra} \nNota final: {media}");
            Console.ReadKey();
        }
    }
}
