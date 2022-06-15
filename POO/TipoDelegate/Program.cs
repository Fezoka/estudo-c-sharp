using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void operacao(int num1, int num2);

        static void Main(string[] args)
        {
            inicio:

            matematica m = new matematica();

            operacao conta = null;

            Console.WriteLine("#################\n#Seja Bem-Vindo!#\n#################\n\n");

            Console.Write("Qual primeiro numero a adicionar a operação? :");
            int primeiro = int.Parse(Console.ReadLine());

            Console.Write("\n\nQual segundo numero a adicionar a operação? :");
            int segundo = int.Parse(Console.ReadLine());


            Console.Write("\n\nDeseja realizar qual operação?\n - , + , * ou / : ");
            char qual_operacao = Convert.ToChar(Console.ReadLine());
            if (qual_operacao == '-')
            {
                Console.WriteLine("");
                conta += m.subtrair;
                conta(primeiro, segundo);

            } else
            if (qual_operacao == '+')
            {
                Console.WriteLine("");
                conta += m.somar;
                conta(primeiro, segundo);

            } else
            if (qual_operacao == '*')
            {
                Console.WriteLine("");
                conta += m.multiplicar;
                conta(primeiro, segundo);

            } else
            if (qual_operacao == '/')
            {
                Console.WriteLine("");
                conta += m.dividir;
                conta(primeiro, segundo);


            }

            Console.WriteLine("Deseja repetir?\n");
            string rsp = Console.ReadLine();

            if (rsp == "s" || rsp == "S" || rsp == "sim"  || rsp == "Sim" || rsp == "SIM" || rsp == "Claro" || rsp == "claro")
            {
                Console.Clear();
                goto inicio;
            }


        }
    }
}
