using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor___Aluno
{
    class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {

        }

        public void IrparaEscola()
        {
            Comprimentar();

            Console.WriteLine("\nEstou indo para a Escola!!");
        }
    }
}
