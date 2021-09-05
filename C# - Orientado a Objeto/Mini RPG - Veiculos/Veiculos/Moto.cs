using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Moto : Veiculos
    {
        public Moto (int placa, int ano) : base (placa, ano)
        {

        }

        public void ExibirDados()
        {
            Console.Write("\n\n\tModelo: BMW S 1000 RR");
            Console.Write("\n\tPlaca: " + placa);
            Console.Write("\n\tAno: " + ano);
            Console.Write("\n\tQuantidade de Rodas: 2");
            Console.Write("\n\tQuantidade de Assentos: 1");
        }

        public void Empinar()
        {
            Console.Write("A moto esta empinando");
        }
    }
}
