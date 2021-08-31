using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___20_a_90_anos
{
    class Program
    {
        static void Main(string[] args) 
        {
            int idade;
            string nome;

            Console.Write("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            idade = int.Parse(Console.ReadLine());

            Console.Write(nome + "\n \n" + (idade >= 20 && idade <= 90 ? "Você está entre o grupo do 20 aos 90, está apto" 
                : "Você não está no grupo dos 20 aos 90, nao está apto"));
            Console.ReadKey();
        }
    }
}
