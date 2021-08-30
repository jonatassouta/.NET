using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Juros
{
    class Juros
    {
        static void Main(string[] args)
        {
            double conta, final;
            const double juros = 0.007;

            Console.Write("Qual valor deseja depositar? ");
            conta = double.Parse(Console.ReadLine());

            final = conta + (conta * juros);

            Console.WriteLine("Sua conta ao final do mês com um juros de 0,7% ficaria: " + final);
            Console.ReadKey();
        }
    }
}
