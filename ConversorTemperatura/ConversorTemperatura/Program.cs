using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURA ### ");
            Console.WriteLine("Insira a temperatura em Celsius :");
            Console.WriteLine("----------------------------------");
            c = Double.Parse(Console.ReadLine());
            f = (c * 1.8) + 32;
            k = c + 273.15;

            Console.WriteLine("----------------------------------");
            Console.WriteLine(c + " graus em Celsius se torna : " + f + " graus em Fahrenheit");
            Console.WriteLine(c + " graus em Celsius se torna : " + k + " graus em Kelvin");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();

        }
    }
}
