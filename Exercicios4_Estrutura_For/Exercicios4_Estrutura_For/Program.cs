using System;
using System.Globalization;

namespace Exercicios4_Estrutura_For
{
    class Program
    {
        //Método que mostra os números impares do N digitado
        static void Exercicio1()
        {
            int x = 0;
            Console.WriteLine("Digite um número inteiro de 1 a 1000");
            x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 0; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("O valor digitado é inválido!");
            }

        }

        //Método que mostra quais numeros estão dentro do intervalo de 10 até 20 incluindo os extremos
        static void Exercicio2()
        {
            int numeroValores, valor = 0;
            int dentro = 0, fora = 0;

            Console.WriteLine("Digite o número de valores:");
            numeroValores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroValores; i++)
            {
                Console.WriteLine("Digite o {0}º valor:", i + 1);
                valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine
            (
                "{0} in\n"
                + "{1} out"
                , dentro, fora
            );
        }

        //Método que realiza a média ponderada de N testes
        static void Exercicio3()
        {
            int numeroTestes;
            double a = 0, b = 0, c = 0, mediaPonderada;

            Console.WriteLine("Digite o número de testes:");
            numeroTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroTestes; i++)
            {
                string[] testes = Console.ReadLine().Split(' ');

                a = double.Parse(testes[0], CultureInfo.InvariantCulture);
                b = double.Parse(testes[1], CultureInfo.InvariantCulture);
                c = double.Parse(testes[2], CultureInfo.InvariantCulture);

                mediaPonderada = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        //Método que realiza a divisão de N pares
        static void Exercicio4()
        {
            int qtdPares, n1, n2, divisao;

            Console.WriteLine("Digite a quantidade de pares:");
            qtdPares = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdPares; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');

                n1 = int.Parse(pares[0], CultureInfo.InvariantCulture);
                n2 = int.Parse(pares[1], CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    divisao = n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }

        }

        //Método que realiza o fatorial
        static void Exercicio5()
        {
            int n = 0, fatorial = 0;

            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                fatorial = n;
                for (int i = 1; i < n; i++)
                {
                    fatorial *= (n - i);
                }
            }
            else
            {
                fatorial = 1;
            }

            Console.WriteLine(fatorial);

        }

        //Método que mostra todos divisores de um número N
        static void Exercicio6()
        {
            int n;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Método que mostra o número da linha, depois o quadrado e o cubo do valor
        static void Exercicio7() 
        {
            int n;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3));
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

        }
    }
}
