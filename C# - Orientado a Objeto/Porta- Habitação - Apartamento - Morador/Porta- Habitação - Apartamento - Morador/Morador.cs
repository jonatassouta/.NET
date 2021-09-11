using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    public class Morador : Pessoa
    {
        public Habitacao hab;
        public Apartamento ape;
        public Morador (string nome, int idade, Habitacao hab) : base(nome, idade)
        {
            this.hab = hab;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Me chamo {nome}");
            Console.WriteLine($"Tenho {idade} anos");
            Console.WriteLine($"Sou morador do apatamento 37, Minha habitação tem {hab.area} m², e a cor da porta é {hab.porta.cor}");  
        }
    }
}
