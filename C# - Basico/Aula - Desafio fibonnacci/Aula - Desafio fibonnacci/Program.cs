using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Desafio_fibonnacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fn = 0, fn = 1, aux;

            for (int i = 0; i < 110; i++)
            {
                aux = Fn;
                Fn = fn;
                fn = Fn + aux;
                Console.WriteLine("{0}", fn);
            }

            Console.ReadKey();
        }
    }
}
