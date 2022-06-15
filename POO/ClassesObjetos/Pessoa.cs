using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {

        public string nome, sobrenome, mes;
        public int dia, ano;

        // Métodos simples (voi n tem retorno ou seja, passivo)
        public void Comprimentar()
        {
            Console.WriteLine("Muito Obrigado por me executar : )");
            Console.WriteLine("© Felipe Soares");
        }


    }
}
