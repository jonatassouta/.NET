using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Caminhao p1 = new Caminhao(123256, 2021);
            Carro p2 = new Carro(748998, 2021);
            Moto p3 = new Moto(3355225, 2021);

            int escolha;
            int opc;


            Console.Write("Escolha um veiculo (1)CARRO (2)MOTO (3)CAMINHÃO:  ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("\nVocê escolheu o Carro.");
                    break;

                case 2:
                    Console.Write("\nVocê escolheu a Moto.");
                    break;

                case 3:
                    Console.Write("\nVocê escolheu o Caminhão.");
                    break;

                default:
                    Console.Write("\nOpção invalida!!");
                    break;
            }

            //CAMINHÃO

            if (escolha == 3)
            {
                p1.ExibirDados();
                Console.ReadKey();

                do
                {
                    Console.Write("\n\nVocê entra no CAMINHÃO o que quer fazer?\n\n\t(1)Acelerrar (2)Buzinar.  ");
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1)
                    {
                        p1.Acelerar();
                        Console.ReadKey();

                        Console.Write("\n\nVocê chega em um sinal, e ele esta vermelhor o que você faz? \n\n\t(1)Passar no Vermelho (2)Esperar.  ");
                        opc = int.Parse(Console.ReadLine());

                        if (opc == 1)
                        {
                            Console.Write("\n\nVocê acelera o veiculo e passo com o sinal vermelho...\n" +
                                "Logo após escuta um sinal sonoro da policia pedindo para você estacionar: \n\n\t(1)Dar fuga!! (2)Parar. ");
                            opc = int.Parse(Console.ReadLine());

                            if (opc == 1)
                            {
                                p1.DarFuga();
                                Console.ReadKey();

                                Console.Write("\n\nVocê acelera o CAMINHÃO ao maximo, porem ele é muito pesado e lento... " +
                                    "\nA policia logo alcança e você e o veiculo são preso \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();

                            }
                            else
                            {
                                p1.Parar();
                                Console.ReadKey();

                                Console.Write("\n\nAssim que você estaciona, A policial chega ao seu " +
                                    "lado na porta e pede sua Habilitação..");

                                Console.Write("\n\nVocê leva uma multa de R$ 3000,00 reais!!! Hahaha SE F#$&*# \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Write("\n\nVocê esperar o sinal abrir, e logo pega a pista... \n" +
                                "Você acelera o CAMINHÃO em direção ao por do sol <3\n\n\n\n\t--------FIM--------");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        p1.Buzinar();
                        Console.ReadKey();
                    }
                } while (true);               
            }

            //CARRO

            else if (escolha == 1)
            {
                p2.ExibirDados();
                Console.ReadKey();

                do
                {
                    Console.Write("\n\nVocê entra no CARRO o que quer fazer?\n\n\t(1)Acelerrar (2)Buzinar.  ");
                    opc = int.Parse(Console.ReadLine());
               
                    if (opc == 1)
                    {
                        p2.Acelerar();
                        Console.ReadKey();

                        Console.Write("\n\nVocê chega em um sinal, e ele esta vermelhor o que você faz? \n\n\t(1)Passar no Vermelho (2)Esperar.  ");
                        opc = int.Parse(Console.ReadLine());

                        if (opc == 1)
                        {
                            Console.Write("\n\nVocê acelera o CARRO e passo com o sinal vermelho...\n" +
                                "Logo após escuta um sinal sonoro da policia pedindo para você estacionar: \n\n\t(1)Dar fuga!! (2)Parar. ");
                            opc = int.Parse(Console.ReadLine());

                            if (opc == 1)
                            {
                                p2.DarFuga();
                                Console.ReadKey();

                                Console.Write("\n\nVocê acelera o CARRO ao máximo, derrepende a paisagem vira um borrão... " +
                                    "\nA policia não consegue te acompanhar, Você esta livre!!!! \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();

                            }
                            else
                            {
                                p2.Parar();
                                Console.ReadKey();

                                Console.Write("\n\nAssim que você estaciona, A policial chega ao seu " +
                                    "lado na porta e pede sua Habilitação..");

                                Console.Write("\n\nVocê leva uma multa de R$ 3000,00 reais!!! Hahaha SE F#$&*# \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Write("\n\nVocê esperar o sinal abrir, e logo pega a pista... \n" +
                                "Você acelera o CARRO em direção ao por do sol <3\n\n\n\n\t--------FIM--------");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        p2.Buzinar();
                        Console.ReadKey();
                    } 
                } while (true);
                    
                
            }

            //MOTO

            else if (escolha == 2)
            {
                p3.ExibirDados();
                Console.ReadKey();

                do
                {
                    Console.Write("\n\nVocê sobe na MOTO o que quer fazer?\n\n\t(1)Acelerrar (2)Buzinar.  ");
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1)
                    {
                        p3.Acelerar();
                        Console.ReadKey();

                        Console.Write("\n\nVocê chega em um sinal, e ele esta vermelhor o que você faz? \n\n\t(1)Passar no Vermelho (2)Esperar.  ");
                        opc = int.Parse(Console.ReadLine());

                        if (opc == 1)
                        {
                            Console.Write("\n\nVocê acelera a MOTO e passa com o sinal vermelho...\n" +
                                "Logo após escuta um sinal sonoro da policia pedindo para você estacionar: \n\n\t(1)Dar fuga!! (2)Parar. ");
                            opc = int.Parse(Console.ReadLine());

                            if (opc == 1)
                            {
                                p3.DarFuga();
                                Console.ReadKey();

                                Console.Write("\n\nVocê acelera a MOTO ao máximo, derrepende a paisagem vira um borrão... " +
                                    "\nA policia não consegue te acompanhar, Você esta livre!!!! \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();

                            }
                            else
                            {
                                p3.Parar();
                                Console.ReadKey();

                                Console.Write("\n\nAssim que você estaciona, A policial chega ao seu " +
                                    "lado na porta e pede sua Habilitação..");

                                Console.Write("\n\nVocê leva uma multa de R$ 3000,00 reais!!! Hahaha SE F#$&*# \n\n\n\n\t--------FIM--------");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Write("\n\nVocê esperar o sinal abrir, e logo pega a pista... \n" +
                                "Você acelera a MOTO em direção ao por do sol <3\n\n\n\n\t--------FIM--------");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        p3.Buzinar();
                        Console.ReadKey();
                    }
                } while (true);            
            }

            Console.ReadKey();
        }
    }
}
