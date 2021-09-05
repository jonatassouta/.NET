using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulos___Autura__e_Largura
{
    public class Retangulo
    {
        public int largura { get; set; }
        public int altura { get; set; }

        public Retangulo(int largura, int altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public void Mostar()
        {
            Console.WriteLine("\n\nLargura: " + this.largura);
            Console.WriteLine("Altura: " + this.altura);
        }
    }
}
