using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor___Aluno
{
    class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {

        }

        public void Assunto()
        {
            Comprimentar();

            Console.WriteLine("\nHoje iremos falar de Interface C#");
        }

    }
}
