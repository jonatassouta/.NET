using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Caminhao : Veiculos
    {
        public Caminhao(int placa, int ano) : base(placa, ano)
        {
           
        }

        public void ExibirDados()
        {
            Console.Write("\n\n\tModelo: Scania R440");
            Console.Write("\n\tPlaca: " + placa);
            Console.Write("\n\tAno: " + ano);
            Console.Write("\n\tQuantidade de Rodas: 7");
            Console.Write("\n\tQuantidade de Assentos: 3");
        }
    }
}
