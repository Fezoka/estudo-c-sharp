using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverter_nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.Write("Digite o Primeiro nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o Segundo nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o Terceiro nome: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o Quarto nome: ");
            nome4 = Console.ReadLine();

            Console.ReadKey();

            // Mecanismo para inverter os nomes

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;


            // Nomes ja invertidos

            Console.WriteLine("Nomes sequencialmente invertidos: ");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();

        }
    }
}
