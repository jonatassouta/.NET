using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___Idade_narrador
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Qual a idade do narrador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.Write("\n\tCategoria Infantil A");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.Write("\n\tCategoria Infantil B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.Write("\n\tCategoria Juvenil A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.Write("\n\tCategoria Juvenil B");
            }
            else if (idade >= 18 && idade <= 25)
            {
                Console.Write("\n\tCategoria Sênior");
            }
            else
            {
                Console.Write("\n\tNão pertence a nenhuma categoria");
            }


            Console.ReadKey();
        }
    }
}
