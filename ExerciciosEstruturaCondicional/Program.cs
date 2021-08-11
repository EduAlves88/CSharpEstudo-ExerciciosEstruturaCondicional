using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler um número inteiro,
            //e depois dizer se este número é negativo ou não
            int valor;
            Console.WriteLine("Entre com um valor para saber se é Negativo: ");
            valor = int.Parse(Console.ReadLine());
            if (valor < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }


        }
    }
}
