using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_de_combustivel
{
    class Combustivel
    {
        static void Main(string[] args)
        {
            double a, b, c, d, consumo;

            Console.WriteLine("Qual a kilometragem inicial do percurso em km? ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a kilometragem final do percurso em km? ");
            b = double.Parse(Console.ReadLine());


            Console.WriteLine("Quantos de combustivel gastou em L? ");
            c = double.Parse(Console.ReadLine());

            d = b - a;

            consumo = d / c;

            Console.WriteLine("\n \n Distancia inicial: {0} \n Distancia final: {1} \n Distancia percorrida: {2} \n " +
                "A cada litro consumido o veiculo percorreu: {3} km", a, b, d, consumo);
            c = double.Parse(Console.ReadLine());
        }
    }
}
