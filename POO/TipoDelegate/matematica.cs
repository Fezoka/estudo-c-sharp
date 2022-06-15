using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class matematica
    {
        public void somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("########################\nResultado da soma: " + resultado + "\n########################\n\n");
        }
        public void subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            Console.WriteLine("########################\nResultado da subtração: " + resultado + "\n########################\n\n");
        }
        public void dividir(int num1, int num2)
        {
            int resultado = num1 * num2;
            Console.WriteLine("########################\nResultado da divisão: " + resultado + "\n########################\n\n");
        }
        public void multiplicar(int num1, int num2)
        {
            int resultado = num1 / num2;
            Console.WriteLine("########################\nResultado da multiplicação: " + resultado + "\n########################\n\n");
        }
    }
}
