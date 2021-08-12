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
            resto = parouimpar % 2;
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
            Console.WriteLine("Digite os valores para comprovar se são divisíveis");
            valIn = Console.ReadLine();
            string[] vetValores = valIn.Split(' ');
            int val1 = int.Parse(vetValores[0]);
            int val2 = int.Parse(vetValores[1]);
            float divisao = val1 / val2;
            float restoDaDivisao = divisao % 2;
            if (restoDaDivisao > 0)
            {
                Console.WriteLine("Não é Divisível!");
            }
            else
            {
                Console.WriteLine("É Divisível!");
            }

            //Leia a hora inicial e a hora final de um jogo.
            //A seguir calcule a duração do jogo,
            //sabendo que o mesmo pode começar em um dia e terminar em outro,
            //tendo uma duração mínima de 1 hora e máxima de 24 horas.
            string tempoJogo;
            int horaTotal;
            Console.WriteLine("Digite os valores de inicio e fim do jogo");
            tempoJogo = Console.ReadLine();
            string[] vetHoras = tempoJogo.Split(' ');
            int horaIn = int.Parse(vetHoras[0]);
            int horaFi = int.Parse(vetHoras[1]);

            if (horaFi > horaIn)
            {
                horaTotal = (horaFi - horaIn);
                Console.WriteLine("O JOGO DUROU " + horaTotal + "HORA(S)");
            }
            else if (horaFi < horaIn)
            {
                horaTotal = ((24 - horaIn) + horaFi);
                Console.WriteLine("O JOGO DUROU " + horaTotal + "HORA(S)");
            }
            else
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");

            //Com base na tabela abaixo,
            //escreva um programa que leia o código de um item
            //e a quantidade deste item.
            //A seguir, calcule e mostre o valor da conta a pagar

            //1 - Cachorro-Quente R$4.00
            //2 - X-Salada R$4.50
            //3 - X-Bacon R$5.00
            //4 - Torrada Simples R$2.00
            //5 - Refrigerante R$1.50

            Console.WriteLine("Digite o código do produto e a quantidade: ");
            string pedido = Console.ReadLine();
            string[] vetPedido = pedido.Split(' ');

            int cod = int.Parse(vetPedido[0]);
            int quantidade = int.Parse(vetPedido[1]);

            if (cod == 1)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.00));
            }
            else if (cod == 2)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.50));
            }
            else if (cod == 3)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 5.00));
            }
            else if (cod == 4)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 2.00));
            }
            else if (cod == 5)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 1.50));
            }
            else
                Console.WriteLine("Código de produto não encontrado!!!");

            //Você deve fazer um programa que leia um valor qualquer e
            //apresente uma mensagem dizendo em qual dos 
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra.
            //Obviamente se o valor não estiver em
            // nenhum destes intervalos,
            //deverá ser impressa a mensagem “Fora de intervalo”
            
            
            



        }
    }
}
