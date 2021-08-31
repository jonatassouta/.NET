using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40___Seguro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, grupo_risco;
            int idade, risco = 0;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Grupo de risco: BAIXO (B) MEDIO (M) OU ALTO (A) ");
            grupo_risco = Console.ReadLine();

            if (idade >= 17 && idade <= 21)
            {
                if (grupo_risco == "b" || grupo_risco == "B")
                {
                    risco = 1;
                }

                if (grupo_risco == "m" || grupo_risco == "M")
                {
                    risco = 2;
                }

                if (grupo_risco == "a" || grupo_risco == "A")
                {
                    risco = 3;
                }
            }

            if (idade >= 21 && idade <= 24)
            {
                if (grupo_risco == "b" || grupo_risco == "B")
                {
                    risco = 2;
                }

                if (grupo_risco == "m" || grupo_risco == "M")
                {
                    risco = 3;
                }

                if (grupo_risco == "a" || grupo_risco == "A")
                {
                    risco = 4;
                }
            }

            if (idade >= 25 && idade <= 34)
            {
                if (grupo_risco == "b" || grupo_risco == "B")
                {
                    risco = 3;
                }

                if (grupo_risco == "m" || grupo_risco == "M")
                {
                    risco = 4;
                }

                if (grupo_risco == "a" || grupo_risco == "A")
                {
                    risco = 5;
                }
            }

            if (idade >= 35 && idade <= 64)
            {
                if (grupo_risco == "b" || grupo_risco == "B")
                {
                    risco = 4;
                }

                if (grupo_risco == "m" || grupo_risco == "M")
                {
                    risco = 5;
                }

                if (grupo_risco == "a" || grupo_risco == "A")
                {
                    risco = 6;
                }
            }

            if (idade >= 65 && idade <= 70)
            {
                if (grupo_risco == "b" || grupo_risco == "B")
                {
                    risco = 7;
                }

                if (grupo_risco == "m" || grupo_risco == "M")
                {
                    risco = 8;
                }

                if (grupo_risco == "a" || grupo_risco == "A")
                {
                    risco = 9;
                }
            }


            Console.Write($"\n\n\tNome: {nome} \n\tIdade: {idade} \n\tCategoria: {risco}");
            
            Console.ReadKey();
        }
    }
}
