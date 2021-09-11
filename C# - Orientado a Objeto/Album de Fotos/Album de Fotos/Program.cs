using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album_de_Fotos
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 'z';
            do
            {
                Console.Write("Olá bom dia, Quantas paginas você quer no seu album? ");
                int pumeroTotalDePaginas = int.Parse(Console.ReadLine());

                AlbumDeFotos familia = new AlbumDeFotos(pumeroTotalDePaginas);

                familia.Dados();

                familia.ExibirDados();
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Aperte S se deseja pedir um novo album, ou qualquer tecla para sair...");
                while (opcao != 'S')
                {                    
                    opcao = char.Parse(Console.ReadLine());
                    opcao = Char.ToUpper(opcao);
                }

                Console.Clear();
            }while (opcao == 'S');
        }
    }
}
