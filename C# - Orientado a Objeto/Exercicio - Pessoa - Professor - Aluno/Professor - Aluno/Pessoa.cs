using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor___Aluno
{
    public class Pessoa
    {
        public string nome { get; private set; }

        public int idade { get; private set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public virtual void Comprimentar() { 
            
            int opc;

            Console.Write("\n\nComo deseja comprientar: \n\t\t(1)BOM DIA (2)BOA TARDE (3)BOA NOITE   ");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.Write("\nBoom diiiaa!!! :D");
            }
            else if (opc == 2)
            {
                Console.Write("\nBoom tardee!!! :D");
            }
            else
            {
                Console.Write("\nBoom noiitee!!! :D");
            }

            Console.Write($"\nMeu nome  é {nome}");

            DizerIdade(idade);
        }

        public void DizerIdade(int idade)
        {
            Console.Write($"\nTenho {idade} anos");
        }
    }
}
