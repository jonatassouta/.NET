using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Idade___com_orientação
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.Write("\t\t\t\t\t--------------Calculo idade------------\n\n ");

            Console.Write("\t\t\t\t\tDigite o nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("\t\t\t\t\tDigite o Ano de Nascimento: ");
            p1.AnoNascimento = Convert.ToInt32(Console.ReadLine());//ou int.Parse

            Console.Write("\n\t\t\t\t\tVocê deseja saber seu IMC? S OU N: ");
            p1.OPC = Console.ReadLine();
            p1.OPC = p1.OPC.ToUpper();

            //Chamar os métodos

            p1.ExibirDados();

            Console.ReadKey();
        }
    }
}
