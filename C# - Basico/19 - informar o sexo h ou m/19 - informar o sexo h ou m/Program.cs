using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___informar_o_sexo_h_ou_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 0, F = 0;
            string[] sexo = new string [56];

            for (int i = 0; i < 56; i++)
            {
                Console.Write("Informe qual o sexo M masculino F feminino: ");
                sexo[i]= Console.ReadLine();

                if(sexo[i] == "M") 
                {
                    M++;
                }
                else
                {
                    F++;
                }
            }

            Console.Write($"\n \n O numero de homens é {M} e de mulheres são {F}");

            Console.ReadKey();
        }
    }
}
