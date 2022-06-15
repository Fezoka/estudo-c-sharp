using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
        init:

            #region Minha apresentação

            Console.Clear();

            Console.WriteLine("#############################################");
            Console.WriteLine("###                                       ###");
            Console.WriteLine("###   By    ©Fezoka Jv       :)           ###");
            Console.WriteLine("###                                       ###");
            Console.WriteLine("###                                       ###");
            Console.WriteLine("###          Seja Bem-vindo(a) !          ###");
            Console.WriteLine("###                                       ###");
            Console.WriteLine("###                                       ###");
            Console.WriteLine("#############################################");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

            #region Classe estática
            /*

            int liquido;

            Console.WriteLine("#### Calculadora de taxas ####");
            Console.WriteLine("");


            Console.Write("Qual seria o valor da taxa? ");
            Matematica.taxa = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.Write("Agora nos informe o valor bruto: ");
            liquido = int.Parse(Console.ReadLine());
            Console.WriteLine("");


        opcao:
            Console.Write("Deseja adicionar ou retirar a taxa? (responda com - ou +) ");
            char op = char.Parse(Console.ReadLine());


            switch (op)
            {
                default:
                    Console.WriteLine("!!! Selecione uma opção válida !!!");
                    Console.WriteLine("");
                    goto opcao;

                case '+':
                    int somar = Matematica.somar(liquido);
                    Console.WriteLine("Seu valor é de: " + somar);
                    Console.WriteLine("");
                    break;

                case '-':
                    int subtrair = Matematica.subtrair(liquido);
                    Console.WriteLine("Seu valor é de: " + subtrair);
                    Console.WriteLine("");
                    break;

            }

            opcao2:
            Console.WriteLine("");
            Console.WriteLine("Deseja realizar um novo cálculo?: (responda com S ou N)");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                default:
                    Console.WriteLine("!!! Selecione uma opção válida !!!");
                    Console.WriteLine("");
                    goto opcao2;

                // opções para sim
                case "s":
                    goto init;

                case "S":
                    goto init;

                // opções para não
                case "n":
                    goto fim;

                case "N":
                    goto fim;
            }
        fim:;

            */
            #endregion

            #region Membros estáticos

            #region Início
            Pessoa p1 = new Pessoa();

            Console.WriteLine("#### Calculador de maioridade ####");
            Console.WriteLine("");

            #endregion

            #region Nome

            Console.Write("Nome (apenas primeiro nome): ");
            p1.nome = Console.ReadLine();
            Console.Write("");

            Console.Write("Sobrenome: ");
            p1.sobrenome = Console.ReadLine();
            Console.WriteLine("");

            #endregion

            #region Data de nascimento

            Console.Write("Dia de nascimento (ex: 10): ");
            int dia2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Mês de nascimento (ex: 12): ");
            int mes2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Ano de nascimento (ex: 1990): ");
            int ano2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            #endregion

            #region Dados

            Console.Clear();

            Console.WriteLine("########################################");
            Console.WriteLine("####       DADOS CADASTRADOS        ####");
            Console.WriteLine("########################################");

            Console.WriteLine("");

            p1.Apresentar();

            p1.calcular(0, dia2, mes2, ano2);


        #endregion

            #region Finalização
        op:
            Console.WriteLine("");
            Console.WriteLine("Deseja realizar um novo cálculo?: (responda com S ou N)");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                default:
                    Console.WriteLine("!!! Selecione uma opção válida !!!");
                    Console.WriteLine("");
                    goto op;

                // opções para sim
                case "s":
                    goto init;

                case "S":
                    goto init;

                // opções para não
                case "n":
                    goto fim;

                case "N":
                    goto fim;
            }
        fim:;
            #endregion

            // fim do region Membros estáticos
            #endregion

        }
    }
    }

