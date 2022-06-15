using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos
            /*
            MinhaClasse Classe1 = new MinhaClasse();
            MinhaClasse Classe2 = null;

            OutraClasse Outra1 = new OutraClasse();
            OutraClasse Outra2 = Outra1;
            */
            #endregion

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

        inicio:
            Console.Clear();

            #region Preenchimendo de dados pessoa 1

            Console.WriteLine("### Digite os dados da pessoa 1 ###");

            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            p1.sobrenome = Console.ReadLine();

            Console.Write("Dia de nascimento: ");
            p1.dia = int.Parse(Console.ReadLine());

            Console.Write("Mês de nascimento: ");
            p1.mes = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            p1.ano = int.Parse(Console.ReadLine());

            #endregion

            #region Preenchimendo de dados pessoa 2

            Console.WriteLine("\n### Digite os dados da pessoa 2 ###");

            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            p2.sobrenome = Console.ReadLine();

            Console.Write("Dia de nascimento: ");
            p2.dia = int.Parse(Console.ReadLine());

            Console.Write("Mês de nascimento: ");
            p2.mes = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            p2.ano = int.Parse(Console.ReadLine());

            #endregion

            #region Converter (1) para (jan)

            if (p1.mes == "1" || p1.mes == "01")
            {
                p1.mes = "/Jan/";
            } else
            if (p1.mes == "2" || p1.mes == "02")
            {
                p1.mes = "/Fev/";
            } else
            if (p1.mes == "3" || p1.mes == "03")
            {
                p1.mes = "/Mar/";
            } else
            if (p1.mes == "4" || p1.mes == "04")
            {
                p1.mes = "/Abr/";
            } else
            if (p1.mes == "5" || p1.mes == "05")
            {
                p1.mes = "/Maio/";
            } else
            if (p1.mes == "6" || p1.mes == "06")
            {
                p1.mes = "/Jun/";
            } else
            if (p1.mes == "7" || p1.mes == "07")
            {
                p1.mes = "/Jul/";
            } else
            if (p1.mes == "8" || p1.mes == "08")
            {
                p1.mes = "/Ago/";
            } else
            if (p1.mes == "9" || p1.mes == "09")
            {
                p1.mes = "/Set/";
            } else
            if (p1.mes == "10")
            {
                p1.mes = "/Out/";
            } else
            if (p1.mes == "11")
            {
                p1.mes = "/Nov/";
            } else
            if (p1.mes == "12")
            {
                p1.mes = "/Dez/";
            } 
            else
            {
                Console.WriteLine("Número Inválido !!");
                Console.WriteLine("Aperte qualquer tecla para recomeçar");
                Console.ReadLine();
                goto inicio;
            }

            #endregion

            #region Exibição dos dados

            Console.WriteLine("\n\n### Dados da pessoa 1 ###");
            Console.WriteLine("Nome: " + p1.nome + " " + p1.sobrenome);
            Console.WriteLine("Nascimento: " + p1.dia + p1.mes + p1.ano);

            Console.WriteLine("\n### Dados da pessoa 2 ###");
            Console.WriteLine("Nome: " + p2.nome + " " + p2.sobrenome);
            Console.WriteLine("Nascimento: " + p2.dia + p2.mes + p2.ano);

            #endregion

            p1.Comprimentar();
            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
