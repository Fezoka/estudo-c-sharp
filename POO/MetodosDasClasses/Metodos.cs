using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        #region Metodos
        // Método simples
        public void comprimentar()
        {
            Console.WriteLine("Olá, Seja bem-vindo");
        }

        // Método com parametros
        public void somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.Write("Resultado: ");
            Console.WriteLine(resultado + "\n\n");
        }

        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é: " + nome + " e tenho " + idade + " anos.");
        }

        #endregion

        #region Valores e Referências
        public void aumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é de: " + valor);
        }

        public void aumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é de: " + valor);
        }
        #endregion

        public string MontarNome(string nome, string sobrenome)
        {
            // string NomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            // int codigo = (int)caractere;
            return caractere;
        }

        public double Pi()
        {
            return 3.1415;
        }

        #region Sobrecarga de Métodos (Overloading)

        public void comprimentar(string nome)
        {
            Console.WriteLine("Olá, Seja bem-vindo " + nome + ".");
        }

        public void comprimentar(string nome, int hora)
        {
            Console.WriteLine(hora < 12 ? "Bom dia " : "Boa tarde " + nome + ".");
        }

        public bool comparar(int num1, int num2)
        {
            return num1 == num2;
        }
        public bool comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }

        #endregion

    }
}
