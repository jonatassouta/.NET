using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___descoonto_carro_gasolina_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            
            double valor = 0, valor1 = 0, valor2 = 0, valor3 = 0, opc = 0;

            do
            {
                for (int i = 0; i < 1; i++)
                {
                    int combustivel;

                    Console.Write("Nome do veiculo: ");
                    nome = Console.ReadLine();

                    Console.Write("É gasolina (1) alcool(2) ou diesel(3): ");
                    combustivel = int.Parse(Console.ReadLine());

                    Console.Write("Valor do veiculo: ");
                    valor = double.Parse(Console.ReadLine());                 

                    if (combustivel == 1)
                    {
                        valor1 = valor - (valor * 0.21);
                        Console.Write("\n\n\tValor: " + valor1);
                    }
                    else if (combustivel == 2)
                    {
                        valor2 = valor - (valor * 0.25);
                        Console.Write("\n\n\tValor: " + valor2);
                    }
                    else if (combustivel == 3)
                    {
                        valor3 = valor - (valor * 0.14);
                        Console.Write("\n\n\tValor: " + valor3);
                    }

                    Console.WriteLine($"\n\tVeículo: {nome} \n\tCombustivel: {combustivel} \n\n");
                }

                

            } while (valor != 0);
            

            Console.ReadKey();
        }
    }
}
