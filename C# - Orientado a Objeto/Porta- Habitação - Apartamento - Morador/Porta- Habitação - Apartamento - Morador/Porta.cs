using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    public class Porta
    {
        public string cor { get; set; }

        public Porta(string cor)
        {
            this.cor = "Verde";
        }

        public void MostrarPorta()
        {
            Console.WriteLine($"Eu sou uma porta, minha cor é {this.cor}");
        }
    }
}
