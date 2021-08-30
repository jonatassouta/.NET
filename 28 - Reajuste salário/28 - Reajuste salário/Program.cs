using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Reajuste_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            const int salario_min = 1045;
            double[] salario = new double[3];
            double[] total = new double[3];
            string[] nome = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nInforme o nome do funcionário: ");
                nome[i] = Console.ReadLine();

                Console.Write("Qual o salario recebido: ");
                salario[i] = double.Parse(Console.ReadLine());

                if (salario[i] < 3 * salario_min)
                {
                    total[i] = (salario[i] * 0.50);
                    salario[i] += (salario[i] * 0.50);
                    
                }
                else if (salario[i] >= 3 * salario_min && salario[i] <= 10 * salario_min)
                {
                    total[i] = (salario[i] * 0.20);
                    salario[i] += (salario[i] * 0.20);
                    
                }
                else if (salario[i] > 10 * salario_min && salario[i] <= 20 * salario_min)
                {
                    total[i] = (salario[i] * 0.15);
                    salario[i] += (salario[i] * 0.15);
                    
                }
                else
                {
                    total[i] = (salario[i] * 0.10);
                    salario[i] += (salario[i] * 0.10);
                    
                }
            }

            double soma = 0;

            for (int i = 0; i < 3; i++)
            {
                soma += total[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n\tFuncionario: {nome[i]} \n\tSalario Reajustado: {salario[i]}");
                
            }
            Console.WriteLine($"\t\n\nTotal de almento de gasto na folha de pagamento da empresa: {soma}");

            Console.ReadKey();
        }
    }
}
