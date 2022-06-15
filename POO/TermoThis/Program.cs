using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:

            Acessar teste = new Acessar();
            Console.WriteLine("#################\n#Seja Bem-Vindo!#\n#################\n\n");

            Console.WriteLine("Quem é?? ");
            Console.Write("É o ");
            string user = Console.ReadLine();

            Console.WriteLine("\n\nE qual a senha? ");
            Console.Write("A senha é ");
            string pass = Console.ReadLine();

            if (teste.login(user, pass)){

                Console.Clear();
                Console.WriteLine("Pode entrar !!");
            
            }else
            {

                Console.Clear();
                Console.WriteLine("Quer tentar denovo? !\n");

            }

            string rsp = Console.ReadLine();

            if (rsp == "s" || rsp == "S" || rsp == "sim"  || rsp == "Sim" || rsp == "SIM" || rsp == "Claro" || rsp == "claro" )
            {
                Console.Clear();
                goto inicio;
            }

        }
    }
}
