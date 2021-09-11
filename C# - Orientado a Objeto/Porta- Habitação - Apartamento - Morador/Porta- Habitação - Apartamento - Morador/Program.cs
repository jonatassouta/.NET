using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    class Program
    {
        static void Main(string[] args)
        {
            Morador pessoa = new Morador("Jeniffer", 27, new Apartamento(new Porta("Verde"), 50, 37));

            pessoa.Mostrar();
            Console.ReadKey();
        }
    }
}
