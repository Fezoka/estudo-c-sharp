using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            /*
            int[] numeros = new int[5];     // define q é vetor apenas com []

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            Console.WriteLine(numeros[4]);


            string[] nomes =
            {
                "Felipe",
                "Roberto",
                "Soares",
                "sabe codar"
            };

            nomes[3] = "é mentira";

            Console.WriteLine(nomes[2]);
            */
            #endregion

            #region Matriz
            /*
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.WriteLine("------------- TABELA DE NUMEROS ------------");
            Console.Write("|               [" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.WriteLine("[" + numeros[0, 2] + "]               |");

            Console.Write("|               [" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]               |");

            Console.WriteLine("--------------------------------------------");



            string[,] nomes =
            {
                {"Felipe", "Roberto", "Soares" },
                {"Ana", "Luiza", "Dos santos" }
            };

            Console.WriteLine("------------- TABELA DE NOMES ------------");

            Console.Write("|          [" + nomes[0, 0] + "]");
            Console.Write("[" + nomes[0, 1] + "]");
            Console.WriteLine("[" + nomes[0, 2] + "]       |");

            Console.Write("|          [" + nomes[1, 0] + "]");
            Console.Write("[" + nomes[1, 1] + "]");
            Console.WriteLine("[" + nomes[1, 2] + "]        |");

            Console.WriteLine("--------------------------------------------");
            */
            #endregion

            Console.ReadKey();

        }
    }
}
