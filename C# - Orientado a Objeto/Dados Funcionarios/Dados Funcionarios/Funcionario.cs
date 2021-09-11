using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public int Matricula { get; set; }
        public double HorasTrabalhas { get; set; }
        public double ValorPorHora { get; set; }
        public string CPF { get; set; }

        public Funcionario(string nome, string sobrenome, string cpf, string dataNascimento, int matricula, double horasTrabalhas, double valorPorHora)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Matricula = matricula;
            HorasTrabalhas = horasTrabalhas;
            ValorPorHora = valorPorHora;
            CPF = cpf;
        }

        /*
        public void EntradadeDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("\nSobrenome: ");
            Sobrenome = Console.ReadLine();

            Console.Write("\nCPF: 123.456.789-10 ");
            CPF = Console.ReadLine();

            Console.Write("\nData de Nascimento: (dd/mm/aaaa) ");
            DataNascimento = Console.ReadLine();

            Console.Write("\nMatriculas: ");
            Matricula = int.Parse(Console.ReadLine());

            Console.Write("\nHoras Trabalhadas: ");
            HorasTrabalhas = double.Parse(Console.ReadLine());

            Console.Write("\nValor ganho por Hora: ");
            ValorPorHora = double.Parse(Console.ReadLine());
        }
        */

        public string NomeCompleto()
        {
           Console.WriteLine("\n\n" + Nome + " " + Sobrenome + "\n");

            return Nome;
        }

        public double CalcularSalario()
        {
            double salario;

            salario = HorasTrabalhas * ValorPorHora;

            Console.WriteLine($"O Salario do(a) funcionario(a) {Nome + " " + Sobrenome} é de R${salario} Reais");

            return salario;
        }
    }
}
