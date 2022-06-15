﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Condição encadeada
            /*
            Console.WriteLine("### DIGITE UM VALOR## \n 0 até 99 = Condição 0 //100 até 199 = Condição 1 // 200 até 299 = Condição 2 // 300 até 399 = Condição 3");
            int valor = int.Parse(Console.ReadLine());


            if (valor >= 0 && valor < 100)
            {
                Console.WriteLine("▒▒▒▒▒▒▒▒░░░ ░░▒▒▒░░░░ ░░▒▒▒▒▒▒▒▒▒░░░░       ░░░▒▒▒\n▒▒▒▒▒▒▒░░▓██▓░░▒▒▒░▓███▒░▒▒▒▒▒▒▒░░ ▒▓███████▓░░░░▒\n▒▒▒▒▒▒▒░▓████▒░░▒░▒█████░░▒▒▒▒▒░░▓█████████████░░░\n▒▒▒▒░░░░▓████▒░░░░▒████▓░░░▒▒▒░░████████████████▒░\n▒▒░░░░░ █████  ░░ ▓████░ ░░░▒░░███████▒░░▒▓██████░\n▒░░▓███████████████████████▒░░▒█████▓ ░░░░ ▒█████▓\n▒░▓█████████████████████████░░▓█████░░░░▒░░ ██████\n▒▒░▓███████████████████████▒░░▓█████▒░▒▒▒▒░░██████\n▒▒░░░  █████  ░  ▓████▒ ░░░░░░▓█████▒░▒▒▒▒░ ██████\n▒▒░░░░░████▓ ░░░ █████ ░░░░▒░░▓█████▒░░▒▒▒░░██████\n▒░░░░ ▒████▒ ░░ ░████▓  ░░▒▒▒░▓█████▒░▒▒▒▒░ ██████\n░▒▓▓▓▓█████▓▓▓▓▓▓█████▓▓▓▒░▒░░▓█████▒░▒▒▒▒░░██████\n░█████████████████████████▒░▒░▓█████▒░▒▒▒▒░ ██████\n░█████████████████████████░▒░░▒█████▒░░░░░░ ██████\n░░▒▒░▓████▓░▒▒▒▒█████░▒▒▒░░▒▒░░██████▒░ ░ ░██████▒\n░▒░░ ▓████░░░░ ▒████▓░░░░░▒▒▒▒░▒█████████████████ \n▒▒▒░░█████░░▒░░▓████▒░▒▒▒▒▒▒▒▒░░▒██████████████▓░░\n▒▒▒▒░▒███▒░▒▒▒░▒▓██▓░░▒▒▒▒▒▒▒▒▒░░ ▒▓█████████▓ ░░▒");
            }
            else if (valor >= 100 && valor < 200)
            {
                Console.WriteLine("░░░░▒░░░░░░░▒░▒░░░░░░░░░░░░░░░░░░     ░░▒░░░░░░░▒░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   ████▓░░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░   ▒███████ ░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░███████████ ░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░▒███████████ ░░░░░░░░░░░\n░░░░░░░░░░░░░░▒░░░░▒░░░░░░░▒▒▒▓███████ ░░░░░░░░░░░\n░░░░░░░░░░░  ██▒  ██▓░░░░░░░░  ███████ ░░░░░░░░░░░\n░░░░░░░░░░░ ▒██  ░██░ ░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░▓███████████▓░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░░▒▒██░░░██▒▒░░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░░▒▓██▒░▒██▒▒░░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░▓███████████▓░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░ ▒██   ██▒ ░░░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░░▓██  ▒██ ░░░░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ███████ ░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ▒▒▒▒▒▒▒ ░░░░░░░░░░░");
            }
            else if (valor >= 200 && valor < 300)
            {
                Console.WriteLine("▒▒▒▒▒▒▒▒░░░░  ░▒░▒░░░░░░ ░▒▒▒▒▒▒▒▒▒▒░░ ░▒▓▓▓▒▒░ ░\n▒▒▒▒▒▒▒▒░▒▓▓▓████▒░░▒▓▓████▓▒▒▒▒▒▒▒▒░░▓██████████▒\n▒▒▒▒▒▒▒░░███████▒░░░███████░░▒▒▒▒▒░░▒█████████████\n▒▒▒▒▒▒▒░░███████░░░▒██████▓░░░▒▒▒▒░▒██████████████\n▒▒▒░▒░░░▒██████░░░░▓██████ ░░░░░░░▒███████████████\n▒▒░░░░ ░▓██████░▒▒▒███████▓▓▓██▒░░████████▒▒▓█████\n▒░▒████████████████████████████▒░▓███████░░░ █████\n░▒▒████████████████████████████░░██▓▓▒▒▒░░░░▒█████\n▒░▒███████████████████████████▓░░░░░░░░░░░░▓██████\n▒▒▒██████████▓▓▓▒▒██████▒░░░░░░░▒▒░░░░░░▒▓████████\n▒░░░   ██████    ▒██████    ░░░▒▒░░░░▒▓██████████▒\n░░░  ░▓██████▒▒▒▒███████▓████▒░░░░░▓███████████▒░░\n▒████████████████████████████░░░░▓█████████▓▒░░░░░\n▒████████████████████████████░░▒████████▒░ ░░░░░░░\n░███████████████████████████▓░▓███████▒ ░░▒▒▒▒▓▓▓░\n░███▓███████▒▒▒░██████▒░░░░░░▒███████████████████░\n░░░  ██████▒░░░░██████░░░░▒░░███████████████████▓░\n▒▒░░▒██████▒░░░▓██████░░▒▒▒░░███████████████████▒░\n▒▒▒░█████▓▓░▒░░█████▓▒░░▒▒▒░▒███████████████████▒░\n▒▒▒░▒▒░ ░░░░▒▒░▓▒░ ░░░░▒▒▒▒░░█▓▓▓▓▓▓▒▒▒▒▒▒▒▒░▒▒▒░░");
            }
            else if (valor >= 300 && valor < 400)
            {
                Console.WriteLine("▒░░░░░░░░░░░▒░░░░░░░▒░▒░▒░░░▒░░░░░░░░░░░░░░░░░▒░░░\n░░░░░▒░░░░░░░▒░▒░░░░░░░░░░░░░░░░░░░░ ░░░░░░░░░░▒░▒\n▒░▒░░░░░░░░░░░▒░░░░░░░░░▒░░░░░  ░▒▒▒▓▒▓▓▒░  ░░░░░░\n░░░▒░░░░▓█▓░░░░░░▓█▒░░░░░░░░░▒█████████████▓ ░░░░░\n▒░▒░░░░ ███ ░░░░ ███ ░░░░░░░████▓▒▒░░░░░▒▓███ ░░▒░\n░░░░░░░ ███ ░░░░ ███    ░░░░▒▒   ░░░░░░░   ██▓░░░▒\n▒░░░░░░ ▓██      ▓███████▓░░░░░░░░░░░░░░░  ███░░▒░\n░░░░░░░ ▒██ ▒▓█████████▓▓░░░░░░░░░░░░░░░░ ░██░░░░░\n▒░░░░  ░▓███████▓▓██     ░░░░░░░░░░░░░░░  ███ ░░▒░\n░░░▓███████▓░    ░██       ░░░░░░░░░    ▒███ ░░░░░\n▒░░████▒░██      ░██▓▓█████▓░░░░░▒▒▒▓█████▓ ░░░░░░\n░░░░     ██░ ▒▓███████████▓▒░░▒██████████   ░░░░░▒\n░░░     ▒████████▓██▒     ░░░░░▓▓▒▒▒░▒████▓ ░░░░▒░\n░░▒▒▒███████▓░    ██▒ ░░░░░░░░░░░░░░░░  ▒███ ░░▒░▒\n░▓█████▓▒██   ░░░ ██▒ ░░░░░░░░░░░░░░░░░░  ██▓ ░░░░\n░▒██▒    ██▒ ░░░░ ██▓░░░░▒░░░▒░░░░░░░░░░░ ▓██ ░░░▒\n░░░░░░░░░██▒░░░░░ ███ ░░▒░░░▒░░░▒░░░░░░░░ ▓██ ░░░░\n░░░░░░░░ ██▓░░░░░░▒█▓░░░░░░░░░░░░░░░░░░░░ ▒██ ░░░▒\n▒░░░░░░░░▓█▒░░░░░░░░░░░░░░▒░░░░░░░░░▒░░░░ ▓██ ░░▒░\n░░░░░▒░░░░░░░░░░░░░░░░░░░▒░▒░░░░░▒░░░░░░  ██▓░░░░░\n▒░▒░▒░░░░░░░░░░░░░░░░░░░░░▒░▒░▒░░░░░░░░  ███ ░░░░░\n░░░░░░░▒░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░░ ▒███ ░░░▒░░\n▒░░░▒░░░▒░░░░░▒░▒░░░░░      ░ ░     ░▓███▓ ░░░░░▒░\n░▒░▒░░░░░▒░▒░░░░░░░░████▓▓▓▓▓▓▓▓▓▓█████▓ ░░░░░░░░░\n▒░░░░░░░░░▒░░░░░░░░░▒███████████████▓░  ░░░░░░░░▒░");
            }
            
            Console.WriteLine("\n \n \n ### JUNTOS SOMOS A RESISTêNCIA ! ###");
            string txt = Console.ReadLine();

            if (txt == "anarch")
            {
            Console.WriteLine("\n                        █                         \n                       ▓█▓                        \n                       ███                        \n                       ████                       \n                       ████                       \n                      █████▓                      \n                    ▒██████████▒                  \n               ▒██████████████████▓░              \n             ░███████████████████████             \n           ▒███████▓████ █████▒████████           \n          ▓██████   ███   ████   ▓██████▒     ▒███\n         ██████    ████   ▓████    ▒████████████▓ \n        █████░    ████▓    ████▓   ░██████████    \n       █████      ████      ███████████████▓      \n       █████     ████     ▓▓█████████▓ ████       \n      █████      ████▓████████████     ████▒      \n      █████   ▓█████████████▓▓████░    ████       \n      █████▓█████████▓▒▒       ████    ████       \n      █████████████▓           ████▓   ████       \n     █████████████▓            ▓████  █████       \n  ▒████████░ ▓████              ████▒▒████        \n ████▓ █████▒████                █████████        \n        █████████                ▒██████▓         \n          ████████▓             ▒██████▓          \n           ░███████████▓▒░░▒▓███████████          \n            ██▓ ██████████████████▓ ████          \n           ███      ▒▓█████████░     ▓██▒         \n           ██                         ░██        ");
            }
            else 
            {
            Console.WriteLine("anarch");
            }
            */
            #endregion

            #region Condição aninhada
            /*
            int numero = 13;
            int condicao = 5;

            if (numero > condicao)
            {
                Console.WriteLine(numero + " é maior que " + condicao);

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é par");
                } else
                {
                    Console.WriteLine(numero + " é ímpar");
                }

            }
            */
            #endregion

            #region Operador ternário
            /*
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            int condicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Pressione qualquer botão para finalizar");

            string mensagem = numero > condicao ? numero + " é maior que " + condicao : numero + " é menor que " + condicao;
            Console.WriteLine(mensagem);

            //Console.WriteLine(numero > condicao ? numero + " é maior que " + condicao : numero + " é menor que " + condicao);
            */
            #endregion

            Console.ReadKey();
        }
    }
}
