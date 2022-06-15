using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Pessoa
    {

        #region Atribuições

        public static int maioridade = 18;

        public string nome;
        public string sobrenome;
        public string nome_int;


        #endregion

        #region Apresentar

        public void Apresentar()
        {
            nome_int = "Nome: " + nome + " " + sobrenome;
            Console.WriteLine(nome_int);
        }

        #endregion

        #region Calcular

        public void calcular(int idade, int dia_Nasc, int mes_Nasc, int ano_Nasc)
        {
            idade = DateTime.Now.Year - ano_Nasc;

            if (mes_Nasc < idade)
            {
                idade--;
            }
            else
            {
                if (mes_Nasc == DateTime.Now.Month)
                {
                    if (dia_Nasc < DateTime.Now.Day)
                    {
                        idade--;
                    }
                    
                }
            }

            if (idade < maioridade)
            {
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Menor de idade!");
            } else
            {
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Maior de idade!");
            }

        } 
        #endregion

    }
}
