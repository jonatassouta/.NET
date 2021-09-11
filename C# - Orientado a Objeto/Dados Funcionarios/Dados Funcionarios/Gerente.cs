using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionarios
{
    public class Gerente : Funcionario
    {
        public string Cargo { get; set; }
        public Gerente(string nome, string sobrenome, string cpf, string dataNascimento, int matricula, double horasTrabalhas, double valorPorHora) : base(nome, sobrenome, cpf, dataNascimento, matricula, horasTrabalhas, valorPorHora)
        {
            this.Nome = "Jeniffer";
            this.Sobrenome = "Guerra";
            Cargo = "Gerente";       
        }

        public void DadosGerente()
        {
            double SalarioGerente = this.SalarioGerente();

            NomeCompleto();
            Console.WriteLine($"Cargo: {Cargo}");

            Console.WriteLine($"\n\tCPF: {CPF}");
            Console.WriteLine($"\n\tData de Nascimento: {DataNascimento}");
            Console.WriteLine($"\tMatricula: {Matricula}");
            Console.WriteLine($"\tHoras trabalhadas: {HorasTrabalhas}");
            Console.WriteLine($"\tValor ganho por hora: {ValorPorHora}");

            Console.WriteLine($"\n\tSalario Gerente: {SalarioGerente}");
        }

        public double SalarioGerente()
        {
            double SalarioGerente;
            double Salario;
            double bonificacao;

            Salario = HorasTrabalhas * ValorPorHora;
            bonificacao = (HorasTrabalhas * ValorPorHora) * 0.2 ;
            SalarioGerente = Salario + bonificacao;
           
            return SalarioGerente;
        }
    }
}
