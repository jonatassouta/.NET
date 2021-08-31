using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___Solicar_Numero_e_imprimir_os_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicitar um numeor e imprimir os numeros impares
            int n;
            
            Console.Write("Informe um número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("Numero: {0} \n" , i);
                }
            }

            Console.ReadKey();
        }
    }
}
