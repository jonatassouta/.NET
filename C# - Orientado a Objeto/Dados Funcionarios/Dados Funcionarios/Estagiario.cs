using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionarios
{
    public class Estagiario : Funcionario
    {
        public string Cargo { get; set; }
        public Estagiario(string nome, string sobrenome, string cpf, string dataNascimento, int matricula, double horasTrabalhas, double valorPorHora) : base(nome, sobrenome, cpf, dataNascimento, matricula, horasTrabalhas, valorPorHora)
        {
            this.Nome = "Lucas";
            this.Sobrenome = "Alves";
            Cargo = "Estagiario";
        }

        public void DadosEstagiario()
        {
            double SalarioEstagiario = this.SalarioEstagiario();

            NomeCompleto();
            Console.WriteLine($"Cargo: {Cargo}");

            Console.WriteLine($"\n\tCPF: {CPF}");
            Console.WriteLine($"\n\tData de Nascimento: {DataNascimento}");
            Console.WriteLine($"\tMatricula: {Matricula}");
            Console.WriteLine($"\tHoras trabalhadas: {HorasTrabalhas}");
            Console.WriteLine($"\tValor ganho por hora: {ValorPorHora}");

            Console.WriteLine($"\n\tSalario Gerente: {SalarioEstagiario}");
        }

        public double SalarioEstagiario()
        {
            double SalarioEstagiario;
            double Salario;
            double bonificacao;

            Salario = HorasTrabalhas * ValorPorHora;
            bonificacao = (HorasTrabalhas * ValorPorHora) * 0.2;
            SalarioEstagiario = Salario / 2;

            return SalarioEstagiario;
        }
    }
}