using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula;
            string nome;
            double salario;
            double venda;
            double comi;
            const double co = 0.15;
            double salarioMes;

            Console.WriteLine("Informe a matricula do funcionario: ");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionario: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o salario fixo do funcionario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de vendas deste mês: ");
            venda = double.Parse(Console.ReadLine());

            comi = venda * co;

            salarioMes = comi + salario;

            Console.WriteLine("Numero da Matricula: {0} \n Nome do funcionario: {1} \n Total de vendas: {2} \n Salario Fixo: {3} \n" +
                " O salario + comição esse mês foi de: {4}",matricula, nome, venda, salario, salarioMes);
            Console.ReadKey();
        }
    }
}
