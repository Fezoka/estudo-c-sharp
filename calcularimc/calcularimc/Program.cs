using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularimc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("### Calculador de IMC ###");

            Console.Write("Digite seu peso (em kilos) : ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (em metros) : ");
            double altura = double.Parse(Console.ReadLine());

            double resultado = peso / (altura * altura);

            if ( resultado >= 16 && resultado < 17)
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Muito abaixo do peso, O que pode acontecer : ");
                Console.WriteLine("Queda de cabelo, infertilidade, ausência menstrual");

            } if ( resultado >= 17 && resultado < 18.5)
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Abaixo do peso, O que pode acontecer : ");
                Console.WriteLine("Fadiga, stress, ansiedade");

            } if ( resultado >= 18.5 && resultado < 25)
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Peso normal, O que pode acontecer : ");
                Console.WriteLine("Menor risco de doenças cardíacas e vasculares");

            } if ( resultado >= 25 && resultado < 30)
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Acima do peso, O que pode acontecer : ");
                Console.WriteLine("Fadiga, má circulação, varizes");

            } if (resultado >= 30 && resultado < 35) 
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Obesidade Grau I, O que pode acontecer : ");
                Console.WriteLine("Menor risco de doenças cardíacas e vasculares");

            } if (resultado >= 35 && resultado < 40) 
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Obesidade Grau II, O que pode acontecer : ");
                Console.WriteLine("Menor risco de doenças cardíacas e vasculares");

            } if (resultado > 40) 
            {
                Console.WriteLine("Seu IMC é : " + resultado);
                Console.WriteLine("Obesidade Grau III, O que pode acontecer : ");
                Console.WriteLine("Menor risco de doenças cardíacas e vasculares");

            }


            Console.ReadKey();
        }
    }
}
