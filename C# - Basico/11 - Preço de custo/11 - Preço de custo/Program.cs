using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Preço_de_custo
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, lucro, valor;

            Console.Write("Qual o preço bruto do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Quantos pretende lucrar em cima (%): ");
            lucro = double.Parse(Console.ReadLine());

            valor = preco + (preco * (lucro / 100));

            Console.Write("O preço de venda é: " + valor);
            Console.ReadKey();
        }
    }
}
