using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public abstract class Veiculos
    {
        public int placa { get; set; }
        public int ano { get; set; }

        protected Veiculos(int placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
        }

        public void Acelerar()
        {
            Console.Write("\n\tVocê acelera o veiculo");
        }

        public void Parar()
        {
            Console.Write("\n\tVocê para o veiculo");
        }

        public void DarFuga()
        {
            Console.Write("\n\tVC está em fuga com o veiculo!!");
        }

        public void Buzinar()
        {
            Console.Write("\n\tVocê buzina!");
        }
    }
}
