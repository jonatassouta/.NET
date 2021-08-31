using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___peso_ideal
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            double altura, idade, peso = 0;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Sexo (M) ou (F): ");
            sexo = Console.ReadLine();

            Console.WriteLine("Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Idade: ");
            idade = double.Parse(Console.ReadLine());


            //HOMEN

            if (sexo == "M" || sexo == "m")
            {
                if(altura > 1.70)
                {
                    if(idade <= 20)
                    {
                        peso = (72.7 * altura) - 58;
                    }

                    if (idade >= 21 && idade <= 39)
                    {
                        peso = (72.7 * altura) - 53;
                    }

                    if (idade >= 40)
                    {
                        peso = (72.7 * altura) - 45;
                    }
                }

                if (altura <= 1.70)
                {
                    if (idade <= 40)
                    {
                        peso = (72.7 * altura) - 50;
                    }

                    if (idade > 40)
                    {
                        peso = (72.7 * altura) - 58;
                    }
                }
            }


            //MULHER

            if (sexo == "F" || sexo == "f")
            {
                if (altura > 1.50)
                {
                    if (idade != 0)
                    {
                        peso = (62.1 * altura) - 44.7;
                    }
                    
                }

                if (altura <= 1.50)
                {
                    if (idade >= 35)
                    {
                        peso = (62.1 * altura) - 45;
                    }

                    if (idade < 35)
                    {
                        peso = (62.1 * altura) - 49;
                    }
                }
            }

            Console.WriteLine($"\n\n\tNome: {nome} \n\tPeso ideal: {peso}");

            Console.ReadKey();
        }
    }
}
