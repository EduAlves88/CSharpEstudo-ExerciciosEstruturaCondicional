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

            //Fazer um programa para ler um número inteiro
            //e dizer se este número é par ou ímpar.
            float parouimpar, resto;
            Console.WriteLine("Entre com um valor para saber se é par ou ímpar: ");
            parouimpar = float.Parse(Console.ReadLine());
            resto = parouimpar%2;    
            if (resto == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }

            //Leia 2 valores inteiros (A e B).
            //Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            //ordem crescente ou decrescente.
            string valIn;
            Console.WriteLine("Digite os valores a serem conferidos");
            valIn = Console.ReadLine();
            string[] vetValores = valIn.Split(' ');
            int val1 = int.Parse(vetValores[0]);
            int val2 = int.Parse(vetValores[1]);
            if (((val1/val2)%2)>0)
            {
                Console.WriteLine( "É Divisível!");
            }
            else
            {
                Console.WriteLine("Não é Divisível!");
            }

            //Leia a hora inicial e a hora final de um jogo.
            //A seguir calcule a duração do jogo,
            //sabendo que o mesmo pode começar em um dia e terminar em outro,
            //tendo uma duração mínima de 1 hora e máxima de 24 horas.

        }
    }
}
