using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___carango_velho
{
    class Program
    {
        static void Main(string[] args)
        {
            double total2000 = 0, total = 0, total_geral = 0 ,desconto1 = 0, desconto2 = 0, valor = 0;
            int ano;
            string opc;

            do
            {
                for (int i = 0; i < 1; i++)
                { 

                    Console.WriteLine("Qual o valor do veiculo?");
                    valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o ano do veiculo?");
                    ano = int.Parse(Console.ReadLine());

                    if (ano <= 2000)
                    {
                        desconto1 = valor - (0.12 * valor);
                        Console.Write("\nO total com desconto de 12%: " + desconto1);
                        total2000++;
                    }
                    else
                    {
                        desconto2 = valor - (0.07 * valor);
                        Console.Write("\nO total com desconto de 7%: " + desconto2);
                        total++;
                    }
                }

                total_geral = total + total2000;
                
                Console.Write($"\n\nO total de carros com ano 2000 é: {total2000}\n E o total geral {total_geral}");

                Console.Write("\n\nDeseja continuar? (s) OU (n)\n \n" );
                opc = Console.ReadLine();
   
            } while (opc == "s");
        }
    }
}
