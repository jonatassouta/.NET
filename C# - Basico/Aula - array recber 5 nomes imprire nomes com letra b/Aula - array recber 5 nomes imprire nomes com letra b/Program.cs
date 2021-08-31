using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___array_recber_5_nomes_imprire_nomes_com_letra_b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um Array para receber 5 nomes, e imprima somentes os nomes que começem com a letra B

            string[] nome = {"Jonatas", "lalla", "Bola", "Jonatas",};

            foreach (string nomeb in nome)
            { 
                if (nomeb.StartsWith("B"))
                {
                    Console.Write(nomeb);
                }              
            }

            Console.ReadKey();
        }    
    }
}
