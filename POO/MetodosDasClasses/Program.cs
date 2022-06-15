using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Metodos m = new Metodos();


            #region Metodos
            /*
            m.comprimentar();

            // Somar
            Console.Write("Primerio número a ser somado: ");
            int num11 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número a ser somado: ");
            int num22 = int.Parse(Console.ReadLine());
            m.somar(num11, num22);

            // Apresentar
            Console.Write("Meu nome é: ");
            string nome1 = Console.ReadLine();
            Console.Write("Minha idade é: ");
            int idade1 = int.Parse(Console.ReadLine());
            m.apresentar(nome1, idade1);
            */
            #endregion

            #region Parâmetros por valor e referência
            /*
        comeco:

            // Somar Valor e Referência
            // Valor
            int valor1 = 100;
            int valor2 = 100;

            m.aumentarValor(valor1);
            m.aumentarRef(ref valor2);

            Console.WriteLine("Primeiro valor final é de: " + valor1);
            Console.WriteLine("Segundo valor final é de: " + valor2);

            string rsp = Console.ReadLine();
            if (rsp == "s")
            {
                goto comeco;
            }
            */
            #endregion

            #region Método retorno de valores
            /*
            // Começo de ====== Montar nome
            Console.Write("Qual seu primeiro nome? :");
            string Primeironome = Console.ReadLine();

            Console.Write("Qual seu sobrenome? :");
            string sobrenome = Console.ReadLine();

            string nome = m.MontarNome(Primeironome, sobrenome);

            Console.WriteLine("Nome completo: " + nome);
            // Final de ====== Montar nome


            // Começo de ====== Codigo Char
            Console.Write("\n\nQual sua camisa jogador caro? :");
            char camisa = Convert.ToChar(Console.ReadLine());

            int codigo = m.CodigoChar(camisa);

            Console.WriteLine("Camisa: " + codigo);
            // Final de ====== Codigo Char


            // Começo de ====== Pi
            double pi = m.Pi();
            Console.WriteLine("\n\n" + pi);
            // Final de ====== Pi
            */
            #endregion

            #region Sobrecarga de Métodos (Overloading)

            m.comprimentar();
            m.comprimentar("Felipe");
            m.comprimentar("Felipe", 18);
            
            bool res1 = m.comparar(14, 7 * 2);
            bool res2 = m.comparar("Felipe", "felipe");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            #endregion

            Console.ReadKey();
        }

    }
}
