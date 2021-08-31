using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico___Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_nascimento, idade;
            int ano_atual = DateTime.Now.Year;
            DateTime data = DateTime.Now;

            Console.Write("Que ano vc nasceu? ");
            ano_nascimento = int.Parse(Console.ReadLine());

            idade = ano_atual - ano_nascimento;

            Console.Write($"Você tem {idade} anos");

            Console.ReadKey();
        }
    }
}
