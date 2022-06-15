using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ciclo While
            /*
            int valor = 0;

            while (valor < 10)
            {
                Console.WriteLine("O valor atual é: " + valor);
                valor++;
            }
            */
            #endregion

            #region Ciclo do-While
            /*
            int valor = 15;

            do
            {
                Console.WriteLine("O valor atual é: " + valor);
                valor--;
            } while (valor < 10);
            */
            #endregion

            #region Ciclo for
            /*
            for (int i = 0, j = 20; i <= 10; i++, j--)
            {
                Console.WriteLine("i = " + i + " | j = " + j);
            }
            */
            #endregion

            #region Foreach
            /*
            string[] nomes = {"Felipe" , "Roberto", "Soares"};

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }
            */
            #endregion

            Console.ReadKey();

        }
    }
}
