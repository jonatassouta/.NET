using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album_de_Fotos
{
    public class AlbumDeFotos
    {
        public int numeroTotalDePaginas { get; set; }

        public int numeroTotalDeFotos { get; set; }

        public int numeroDeFotos { get; set; }

        public AlbumDeFotos(int pumeroTotalDePaginas) 
        {
            numeroTotalDePaginas = pumeroTotalDePaginas;
            numeroTotalDeFotos = numeroTotalDePaginas * 2;
        }

        public void ExibirDados()
        {
            Console.Write("\n\nNumero Total de Páginas é de: " + numeroTotalDePaginas +
            "\nNumero Total de Fotos: " + numeroTotalDeFotos);


            if (numeroDeFotos <= numeroTotalDeFotos)
            {
                Console.Write("\nNumero de fotos guardadas: " + numeroDeFotos);
            }      
        }

        public void Dados()
        {
            Console.Write("\nO total de fotos possiveis para guardar é de " + numeroTotalDeFotos);

            Console.Write("\n\nQuantas fotos você quer guardar? ");
            numeroDeFotos = int.Parse(Console.ReadLine());


            if (numeroDeFotos > numeroTotalDeFotos)
             {
                Console.Clear();
                Console.Write("\nNumero de fotos maior do que limite suportado");
             }
             else
             {
                Console.Clear();
                Console.Write("\nFotos adcionadas com sucesso");
             }
        }
    }
}
