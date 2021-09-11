using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_cacth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine("Exceção tratada!!!");
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }

            Console.ReadLine();
        }

        static public int Dividir(int numero, int divisor)
        {
            return numero /= divisor;
        }

        static void Metodo()
        {
            TestarDivisao(0);
        }

        static public void TestarDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
