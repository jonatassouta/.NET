using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis
            double renda, desc_dependentes, imposto;
            int n_dependentes;
            const int salario_min = 1045;

            //Entrada dos dados
            Console.Write("Qual o sua renda bruta mensal? ");
            renda = double.Parse(Console.ReadLine());

            Console.Write("\nQuantos dependentes você possue? ");
            n_dependentes = int.Parse(Console.ReadLine());

            Console.Write("\n\n.....Regra de imposto:.....\n\n" +
                "Até 2 salario minimos liquidos é isento de imposto \n" +
                "De 2 a 3 salários minimos desconta 5% \n" +
                "De 3 a 5 salários minimos desconta 10% \n" +
                "De 5 a 7 salários minimos desconta 15% \n" +
                "Acima de 7 salários minimos desconta 20% \n \n");

            //Procesamento e saida de dados

            desc_dependentes = n_dependentes * (salario_min * 0.05);
            renda -= desc_dependentes;
            
            if (renda <= 2 * salario_min)
            {
                Console.Write("Sua renda liquida é de {0}. Você está isento do imposto ", renda);
            }else if (renda > 2 * salario_min && renda <= 3 * salario_min)
            {
                imposto = renda - (renda * 0.05);
                Console.Write("Sua renda liquida é de {0}. De 2 a 3 salários minimos desconta 5%. " +
                    "A renda com desoconto é: {1} ", renda, imposto);

            }else if (renda > 3 * salario_min && renda <= 5 * salario_min)
            {
                imposto = renda - (renda * 0.10);
                Console.Write("Sua renda liquida é de {0}. De 3 a 5 salários minimos desconta 10%. " +
                    "A renda com desoconto é: {1} ", renda, imposto);

            }
            else if (renda > 5 * salario_min && renda <= 7 * salario_min)
            {
                imposto = renda - (renda * 0.15);
                Console.Write("Sua renda liquida é de {0}. De 3 a 5 salários minimos desconta 15%. " +
                    "A renda com desoconto é: {1} ", renda, imposto);

            }else
            {
                imposto = renda - (renda * 0.20);
                Console.Write("Sua renda liquida é de {0}. Acima de 7 salários minimos desconta 20%. " +
                    "A renda com desoconto é: {1} ", renda, imposto);
            }

            Console.ReadKey();
        }
    }
}
