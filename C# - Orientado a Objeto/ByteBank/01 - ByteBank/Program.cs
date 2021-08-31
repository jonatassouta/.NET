using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
          // "new ContaCorrente();" Chama a classe como um objeto na memoria do computador
            
          //tipo(String, int)-------------Instancia da clase
            ContaCorrente contaDoCarlos = new ContaCorrente();
          //neste caso o "ContaCorrente" seria o tipo da variavel.

            contaDoCarlos.tituar = "Carlos";       
            contaDoCarlos.agencia = 863;
            contaDoCarlos.numero = 8983213;
            contaDoCarlos.saldo = 100;
          // fez alteração na instancia da classe. A classe em si está intacta.

            Console.WriteLine("Titular: " + contaDoCarlos.tituar);
            Console.WriteLine("Agencia: " + contaDoCarlos.agencia);
            Console.WriteLine("Número: " + contaDoCarlos.numero);

            contaDoCarlos.saldo += 200;
            Console.WriteLine("Saldo: " + contaDoCarlos.saldo);



            Console.ReadLine();
        }
    }
}
