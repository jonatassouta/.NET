using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___Escola_APRENDER
{
    class Program
    {
        static void Main(string[] args)
        {
            int nivel, horas_trabalhadas = 0;

            Console.Write("Qual o seu nivel como professor 1, 2 ou 3? ");
            nivel = int.Parse(Console.ReadLine());

            Console.Write("Qual o total de horas trabalhadas? ");
            horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\tProfessor nivel 1: R$ 12,00 hora/aula \n\tProfessor nivel 2: R$ 17,00 hora/aula" +
                "\n\tProfessor nivel 3: R$ 25,00 hora/aula");

            if (nivel == 1)
            {
                horas_trabalhadas *= 12;
                Console.Write($"\n\n\tO valor do salário é de : R$ {horas_trabalhadas}");
            }
            else if (nivel == 2)
            {
                horas_trabalhadas *= 17;
                Console.Write($"\n\n\tO valor do salário é de : R$ {horas_trabalhadas}");
            }
            else if (nivel == 3)
            {
                horas_trabalhadas *= 25;
                Console.Write($"\n\n\tO valor do salário é de : R$ {horas_trabalhadas}");
            }

            Console.ReadKey();
        }
    }
}
