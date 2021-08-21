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
            int divisao = val1 % val2;

            if (divisao > 0)
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

            Console.WriteLine("Insira um valor entre 0 e 100");
            float valorEntre = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((valorEntre > 0) && (valorEntre < 25))
            {
                Console.WriteLine("Valor entre 0 e 25");
            }
            else if (valorEntre < 50)
            {
                Console.WriteLine("Valor entre 26 e 50");
            }
            else if (valorEntre < 75)
            {
                Console.WriteLine("Valor entre 51 e 75");
            }
            else if (valorEntre < 100)
            {
                Console.WriteLine("Valor entre 76 e 100");
            }
            else
                Console.WriteLine("Fora do intervalo");

            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação
            Console.WriteLine("Entre com os valores de x e y para saber o quadrante: ");
            string xy = Console.ReadLine();
            string[] parabola = xy.Split(' ');
            float x = float.Parse(parabola[0]);
            float y = float.Parse(parabola[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if ((x > 0) && (y > 0))
            {
                //Q1
                Console.WriteLine("Quadrante Q1");
            }
            else if ((x < 0) && (y > 0))
            {
                //Q2
                Console.WriteLine("Quadrante Q2");
            }
            else if ((x < 0) && (y < 0))
            {
                //Q3
                Console.WriteLine("Quadrante Q3");
            }
            else if ((x > 0) && (y < 0))
            {
                //Q4
                Console.WriteLine("Quadrante Q4");
            }
            else
            {
                Console.WriteLine("Ponto na Origem");
            }

            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            //----------------------------------
            //0 a 2000 - isento
            //2000,01 - 3000 -> 8%
            //3000,01 - 4500 -> 18%
            //acima de 4500 -> 28%
            //----------------------------------
            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            Console.WriteLine("Entre com o salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
            if (salario < 2000)
            {
                Console.WriteLine("Saída: ISENTO!");
            }
            else if (salario < 3000)
            {
                imposto = salario * 0.08;
                Console.WriteLine("Saída: " + imposto);
            }
            else if (salario < 4500)
            {
                imposto = salario * 0.18;
                Console.WriteLine("Saída: " + imposto);
            }
            else
            {
                imposto = salario * 0.28;
                Console.WriteLine("Saída: " + imposto);
            }



        }
    }
}
