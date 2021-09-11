using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio_9___Tratar_o_erro_caso_ouver_algum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
            } // laço para preencher o array

            for (int i = 0; i <= x.Length; i++)
            {
                try
                {
                    Console.WriteLine(x[i]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("\n\n" + ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }       
            } // laço para mostrar o array 
         
            Console.ReadKey();
        }
    }
}
