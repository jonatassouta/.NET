using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Carro : Veiculos
    {
        public Carro(int placa, int ano) : base (placa, ano)
        {

        }

        public void ExibirDados()
        {
            Console.Write("\n\n\tModelo: Honda Civic");
            Console.Write("\n\tPlaca: " + placa);
            Console.Write("\n\tAno: " + ano);
            Console.Write("\n\tQuantidade de Rodas: 4");
            Console.Write("\n\tQuantidade de Assentos: 5");
        }
    }
}
