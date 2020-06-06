using System;
using System.Globalization;

namespace Exercicios2_Estrutura_Condicional
{
    class Program
    {
        //Método para verificar se o número é positivo ou negativo
        static void Exercicio1()
        {
            int num;

            Console.WriteLine("Digite um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("POSITIVO");
            }
        }

        //Método para verificar se o número é Par ou Impar
        static void Exercicio2()
        {
            int num;

            Console.WriteLine("Digite um número inteiro:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }

        //Método para verificar se o número é multiplo do outro
        static void Exercicio3() 
        {
            int a, b;
            string[] valores;

            Console.WriteLine("Digite o valor do A e do B separado por espaço:");
            valores = Console.ReadLine().Split(' ');
            
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if ((a % b) == 0 || (b % a) == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }

        }

        //Método para verificar o número horas gastos jogando
        static void Exercicio4() 
        {
            int horaFinal, horaInicial, duracao;
            string[] valores;

            Console.WriteLine("Digite a hora inicial e a hora final do jogo sepado por espaço:");
            valores = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(valores[0]);
            horaFinal = int.Parse(valores[1]);

            if (horaInicial < horaFinal) 
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }

        }

        //Método para verificar o preço total de um produto
        static void Exercicio5() 
        {
            int codigo = 0, quantidade = 0;
            float total;
            string[] valores;

            Console.WriteLine("Digite o código do produto e a quantidade:");
            valores = Console.ReadLine().Split(' ');
            
            codigo = int.Parse(valores[0]);
            quantidade = int.Parse(valores[1]);

            if (codigo == 1) {
                Console.WriteLine("Total: R$ " + (quantidade * 4.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.50f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 5.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 2.00f).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                Console.WriteLine("Total: R$ " + (quantidade * 1.50f).ToString("F2", CultureInfo.InvariantCulture));
            }

        }

        //Método para verificar em qual intervalo o número se encontra
        static void Exercicio6() 
        {
            float num;

            Console.WriteLine("Digite um valor: ");
            num = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num <= 25.00) 
            {
                Console.WriteLine("Intervalo (0,25)");
            }
            else if (num <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50)");
            }
            else if (num <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75)");
            }
            else if (num <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100)");
            }
            else if (num < 0.00 || num > 100.00)
            {
                Console.WriteLine("Fora de intervalor");
            }
        }

        //Método para verificar em qual quadrante se encontra as coordenadas
        static void Exercicio7() 
        {
            float x, y;
            string[] valores;

            Console.WriteLine("Digite o valor de X e Y separado por espaço");
            valores = Console.ReadLine().Split(' ');

            x = float.Parse(valores[0], CultureInfo.InvariantCulture);
            y = float.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            } 
            else if (x > 0.0 && y < 0.0) 
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
        }

        //Método para verificar o valor do imposto de renda com base no salário
        static void Exercicio8()
        {
            double salario, imposto = 0;

            Console.WriteLine("Digite o salário:");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else if (salario > 4500.00) {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else 
            {
                Console.WriteLine("R$ " + imposto.ToString("F2",CultureInfo.InvariantCulture));
            }
        }

        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
        }
    }
}
