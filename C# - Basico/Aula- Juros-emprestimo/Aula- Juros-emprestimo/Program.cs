using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula__Juros_emprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            double emprestimo, juros, valor;
            int dias;

            Console.WriteLine("Valor do empréstimo:");
            emprestimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do juros (%):");
            juros = double.Parse(Console.ReadLine());

            Console.WriteLine("Dias de atraso:");
            dias = int.Parse(Console.ReadLine());

            valor = emprestimo + ((emprestimo * (juros / 100)) * dias);

            Console.Write("O valor da prestação ser pago com juros é de: R$"+ valor);
            Console.ReadKey();
        }
    }
}
