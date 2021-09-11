using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercicio_10___Soma_superior_a_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int soma = 0;

            List<int> listaDeNumeros = new List<int>();

            while (true)
            {
                try
                {
                    Console.WriteLine("Escreva um numero inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    if (soma + num >= 100)
                    {
                        throw new ExcecaoAcimaDeCem("A soma não pode ser maio que 100");
                    }
                    else
                    {
                        soma += num;
                        listaDeNumeros.Add(num);
                    } 
                }
                catch (ExcecaoAcimaDeCem ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            Console.WriteLine($"A soma é : {soma}");
            Console.WriteLine($"Quantidade de numeros somados : {listaDeNumeros.Count}");
            Console.WriteLine($"A Média é : {soma / listaDeNumeros.Count}");

            Console.ReadKey();      
        }
    }

    [Serializable]
    public class ExcecaoAcimaDeCem : Exception
    {
        public ExcecaoAcimaDeCem() { }
        public ExcecaoAcimaDeCem(string message) : base(message) { }
    }
}
