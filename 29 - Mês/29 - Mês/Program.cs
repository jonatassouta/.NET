using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Mês
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int mes = 0;

                Console.Write("Digite um numero de um mes: ");
                mes = int.Parse(Console.ReadLine());

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("Março");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Maio");
                        break;
                    case 6:
                        Console.WriteLine("Junho");
                        break;
                    case 7:
                        Console.WriteLine("Julho");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 0:
                        Console.WriteLine("Setembro");
                        break;
                    case 10:
                        Console.WriteLine("Outrubro");
                        break;
                    case 11:
                        Console.WriteLine("Novembro");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro");
                        break;

                    default:
                        Console.WriteLine("\nMês invalido\n");
                        break;
                }
            } while (default != "Mês invalido");
           
            Console.ReadKey();
        }
    }
}
