using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor___Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof = new Professor("Lucas", 30);
            Pessoa pessoa = new Pessoa("Jonatas", 23);

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("\n\n-------Aluno-----\n\n");

            Aluno aluno = new Aluno(nome, idade);

            aluno.IrparaEscola();

            Console.Write("\n\n-------Pessoa-----\n\n");

            pessoa.Comprimentar();

            Console.Write("\n\n-------Professor-----\n\n");

            prof.Assunto();

            Console.ReadKey();
        }
    }
}
