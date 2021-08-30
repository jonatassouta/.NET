using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30___Salario_Abono
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            double salario, salario_liquido = 0;
            int idade;

            Console.WriteLine("Qual o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sexo (m) ou (f): ");
            sexo = Console.ReadLine();

            Console.WriteLine("Qual a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salario fxo: ");
            salario = double.Parse(Console.ReadLine());

            if (idade >= 30 && sexo == "m")
            {
                salario_liquido = salario + 100;
            }
            else if (idade < 30 && sexo == "m")
            {
                salario_liquido = salario + 50;
            }
            else if (idade >= 30 && sexo == "f")
            {
                salario_liquido = salario + 200;
            }
            else if (idade < 30 && sexo == "f")
            {
                salario_liquido = salario + 80;
            }

            Console.WriteLine($"\n\n\tNOME: {nome} \n\tSALARIO LIQUIDO: {salario_liquido}");

            Console.ReadKey();
        }
    }
}
