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
            Console.Write("Olá bom dia, Quantas paginas você quer no seu album? ");
            int pumeroTotalDePaginas = int.Parse(Console.ReadLine());

            

            AlbumDeFotos familia = new AlbumDeFotos(pumeroTotalDePaginas);

            familia.Dados();

            familia.ExibirDados();
            Console.ReadKey();

        }
    }
}
