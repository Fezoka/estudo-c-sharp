using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();

            Console.WriteLine("### Calculadora ###");
            double valor = 0;
            
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            opcao:
            Console.Write("Digite o seu operador (+, -, x e /): ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                default:
                    Console.WriteLine("!!! Selecione uma opção válida !!!");
                    goto opcao;
                    break;

                case '+':
                    valor = num1 + num2;
                    Console.WriteLine("Resultado: " + valor);
                    break;

                case '-':
                    valor = num1 - num2;
                    Console.WriteLine("Resultado: " + valor);
                    break;

                case 'x':
                case 'X':
                    valor = num1 * num2;
                    Console.WriteLine("Resultado: " + valor);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine(" ### ERRO ###");
                        Console.WriteLine("Nenhum número pode ser divido por 0, digite outro valor");
                        Console.ReadKey();
                        goto inicio;
                    }
                    else
                    {
                        valor = num1 / num2;
                        Console.WriteLine("Resultado: " + valor);
                    }
                    break;
            }

            Console.WriteLine("Deseja realizar um novo cálculo?: ");
            string resposta = Console.ReadLine();

            if (resposta == "s" || resposta == "S")
            {
                goto inicio;
            } else
            {
            }
        }
    }
}
