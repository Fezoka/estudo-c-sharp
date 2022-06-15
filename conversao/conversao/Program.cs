using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implícita
            /*
            byte num1 = 100; // 8 bits. de 0 a 255
            ushort num2; //16 bits, 0 a 65.535

            num2 = num1;

            float num3 = 1274.56f;
            double num4 = num3;

            num3 = num1;

            int numero = 'C';

            Console.WriteLine();
            Console.ReadKey();
            */
            #endregion

            #region Conversão Explícita
            /*
            ushort num1 = 300;          // valor maior do que o byte
            byte num2 = (byte)num1;     // o byte ira carregar, mas se for com mais
   //utilizar o () para transformar     // de 255 ira ter peca de dados !
   //a variável na qual vc quiser atribuir
                                        

            float num3 = 171000.786f;
            int num4 = (int)num3;       

            char letra = (char)102;     // vai imprimir o correspondente ao valor decimal

            Console.WriteLine(letra);
            Console.ReadKey();
            */
            #endregion

            #region Metodo Parse
            /*
            string txtnumero = "2003";          // "2003FS" geraria um erro
            
            int numero = int.Parse(txtnumero);  // converte apenas valores numéricos em string

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("123673,14");    // os valores em string levam , ao inves de .
            // pois estam no idioma do pc / Caso contrário será ignorado

            float num3 = float.Parse("3456,171");
            */
            #endregion

            #region Classe Convert
            /*
            // esse método utiliza do código "Convert." e seguido de algum atributo como "ToDouble"

            string texto = Convert.ToString(240978);    // não precisam de aspas

            double num1 = Convert.ToDouble(false);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
            */
            #endregion



        }
    }
}
