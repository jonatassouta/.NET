﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863146;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863146;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));
            
            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));
            
          //Aqui ele recebe as duas contas, igualando as duas, por isso retorna true.
            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            contaDaGabriela.saldo = 300;

            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);



            Console.ReadLine();
        }
    }
}
