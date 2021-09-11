using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nSobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("\nCPF Ex.( 123.456.789-10 ):   ");
            string cpf = Console.ReadLine();

            Console.Write("\nData de Nascimento (dd/mm/aaaa):  ");
            string dataNascimento =Console.ReadLine();

            Console.Write("\nMatriculas: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.Write("\nHoras Trabalhadas: ");
            double horasTrabalhas = double.Parse(Console.ReadLine());

            Console.Write("\nValor ganho por Hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, sobrenome, cpf, dataNascimento, matricula, horasTrabalhas, valorPorHora);
            Gerente gerente = new Gerente(nome, sobrenome, cpf,  dataNascimento, matricula, horasTrabalhas, valorPorHora);
            Estagiario estagiario = new Estagiario(nome, sobrenome, cpf, dataNascimento, matricula, horasTrabalhas, valorPorHora);

            Console.Clear();

            func.NomeCompleto();
            func.CalcularSalario();
            Console.ReadKey();

            gerente.DadosGerente();
            Console.ReadKey();

            estagiario.DadosEstagiario();
            Console.ReadKey();
        }
    }
}
