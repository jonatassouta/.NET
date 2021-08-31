using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Ler_nome___idade___sexo___saude
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, saude, sexo, m = "", f = "", opc = "";
            int idade;
            

            Console.Write("Serviçõ de seleção militar do estado de São Paulo");

            Console.Write("\n\n------------------------------------------------------------\n\n");

            do
            {
                
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("\nQual o seu nome? ");
                    nome = Console.ReadLine();

                    Console.Write("Qual o seu sexo (m) ou (f)? ");
                    sexo = Console.ReadLine();

                    Console.Write("Qual a sua idade? ");
                    idade = int.Parse(Console.ReadLine());

                    Console.Write("Qual o seu estado de saúde? bom ou ruin? ");
                    saude = Console.ReadLine();

                    string mensagem = $"\n\nNome: {nome} \nSexo: {sexo} \nIdade:{idade} \n\n";

                    if (sexo == "m")
                    {
                        sexo = m;
                    }
                    else
                    {
                        sexo = f;
                    }

                    if (idade >= 18 && saude == "bom")
                    {
                        
                        Console.Write(mensagem + "Você está apto para participar do serviço militar \n");
                    }
                    else
                    {
                        Console.Write(mensagem + "Você não está apto para participar do serviço militar \n");
                    }
                    
                    Console.WriteLine($"");

                    Console.Write("Deseja continuar? (s) ou (n): " );
                    opc = Console.ReadLine();
                }
            } while (opc == "s");

            Console.ReadKey();
        }
    }
}
