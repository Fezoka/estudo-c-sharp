using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritméticos 
            /*
            double num1 = 25;
            double num2 = 5;

            double resultado = num1 + num2;
            double resultado2 = num1 - num2;
            double resultado3 = num1 * num2;
            double resultado4 = num1 / num2;
            double resultado5 = num1 % num2;

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
            Console.WriteLine(resultado5);
            */
            #endregion

            #region Prioridade de sinais
            /*
            double num1 = 125;
            double num2 = 25;
            double num3 = 10;

            double resultado = num1 + num2 * num3;
            double resultado2 = (num1 + num2) * num3;
            double resultado3 = (num1 * num2) / num3;
            double resultado4 = (num1 + num2) * (num1 / num2);



            Console.WriteLine("Prmeiro: " + resultado);
            Console.WriteLine("Segundo: " + resultado2);
            Console.WriteLine("Terceiro: " + resultado3);
            Console.WriteLine("Quarto: " + resultado4);
            */
            #endregion

            #region incremento e decremento
            /*
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int num0 = num1 + 1;
            num1++;

            Console.WriteLine(num1);
            Console.WriteLine(num2++);  // vai imprimir, depois somar 1 (mostra 20)
            Console.WriteLine(--num3);  // vai subtrair 1, depois  imprimir (mostra 29)
            */
            #endregion

            #region Concatenação
            /*
            string nome = "Felipe";
            string sobrenome = "Soares";
            int mesnasc = 12;
            int anonasc = 2003;
            string nomecompleto = "Nome = " + nome + " " + sobrenome;
            string datanasc = "Nascimento = " + mesnasc + "/" + anonasc;

            Console.WriteLine("Nome completo = " + nomecompleto);
            Console.WriteLine("Data de nascimento = " + datanasc);
            */
            #endregion

            #region atribuição
            /*
            int num1 = 10;

            // Tipos de operadores:
            num1 += 10;
            num1 -= 10;
            num1 *= 10;
            num1 /= 10;
            num1 %= 10;


            string nome = "Felipe ";
            nome += "Soares";
            */
            Console.WriteLine();

            #endregion

            #region igualdade / desiqualdade
            /*
            bool res1 = (5 * 2) == (10 % 1000); // True pq é igual
            bool res2 = (500 / 2) != (125 + 125); // False pq é diferente

            string nome = "Felipe";
            bool res3 = "Felipe" == nome;

            Console.WriteLine(res1 + "pq é igual"); 
            Console.WriteLine(res2 + "pq é diferente");
            Console.WriteLine(res3 + "pq é igual");
            */
            #endregion

            #region relacionais
            /*
            bool res1 = 80 > 25 * 3; // True pq 80 é maior q 25x3
            bool res2 = 450 < 2000 / 4; // True pq 450 é menor q 2000/4
            bool res3 = 250 >= 50 + 200; // True pq 250 é igual a 50 + 200, se fosse maior tmb
            bool res4 = 250 <= 50 + 350; // True pq 250 é menor ou igual a 50 + 350 

            Console.WriteLine(res1 + " pq 80 é maior q 25x3");
            Console.WriteLine(res2 + "pq 450 é menor q 2000/4");
            Console.WriteLine(res3 + "pq 250 é igual a 50 + 200, se fosse maior tmb");
            Console.WriteLine(res4 + "pq 250 é menor ou igual a 50 + 350
            */
            #endregion

            #region lógicos
            /*
            bool res1 = 50 * 2 <= 150;
            bool res2 = 1000 != 100 * 15;

            bool final1 = res1 && res2;                                           // precisa os 2 serem true para dar true
            bool final2 = (125 + 125) >= (250 / 2) || (100 - 50) == (100 / 2);    // Precisa 1 ser true para dar true

            Console.WriteLine(final1);
            Console.WriteLine(final2);
            */
            #endregion

            Console.ReadKey();
        }
    }
}
