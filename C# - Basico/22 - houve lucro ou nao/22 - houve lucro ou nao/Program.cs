using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___houve_lucro_ou_nao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] l = new string[2];
            string[] produto = new string[2];
            double[] preço_custo = new double[2];
            double[] preço_venda = new double[2];

            double lucro, media_custo = 0, media_venda = 0, soma1 = 0 ,soma2 = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"\nProduto {i + 1} \n");

                Console.Write("\nInforme o nome do produto: ");
                produto[i] = Console.ReadLine();

                Console.Write("Informe o preço de custo: ");
                preço_custo[i] = double.Parse(Console.ReadLine());

                Console.Write("Informe o preço de venda: ");
                preço_venda[i] = double.Parse(Console.ReadLine());

                soma1 = soma1 + preço_custo[i];
                soma2 = soma2 + preço_venda[i];
               

                lucro = preço_venda[i] - preço_custo[i];

                // Média
               
                media_custo = soma1 / 2;
                media_venda = soma2 / 2;

                //lucro

                if (preço_custo[i] > preço_venda[i])
                {
                    l[i] = $"Você teve um prejuizo de : {lucro}";
                }
                else if (preço_custo[i] < preço_venda[i])
                {
                    l[i] = $"Você teve um lucro de : {lucro}";
                }
                else
                {
                    l[i] = $"Você vendeu o produto a preço de custo.";
                }              
            }
           
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"\n\nProduto: {produto[i]} \n{l[i]} ");   
            }

            Console.Write($"\n\nMédia dos preços de custos: {media_custo} \nMédia dos preços de vendas: {media_venda}");


            Console.ReadKey();
        }
    }
}
