using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Convercao_dolar
{
    class dolar
    {
        static void Main(string[] args)
        {
            double dolar, celulas, real;

            Console.Write("Qual a cotação do dolar? ");
            dolar = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor em dolar que possue? ");
            celulas = double.Parse(Console.ReadLine());

            real = celulas * dolar;

            Console.Write("O valor em reais é: " + real);
            Console.ReadKey();
        }
    }
}
