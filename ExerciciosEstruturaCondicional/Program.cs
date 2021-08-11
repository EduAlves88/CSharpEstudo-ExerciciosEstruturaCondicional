using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Entre com um valor: ");
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
