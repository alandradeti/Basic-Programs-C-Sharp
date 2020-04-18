using System;
using System.Globalization;

namespace Exercicios1_Estrutura_Sequencial
{
    class Program
    {
        static void Exercicio1()
        {
            int num1, num2, soma;

            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);
        }

        static void Exercicio2()
        {
            double raio, area;

            //Entrando com decimal com ponto no lugar da vírgula
            Console.WriteLine("Digite o valor do raio do círculo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        static void Exercicio3()
        {
            int a, b, c, d, diferenca;

            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);

        }

        static void Exercicio4()
        {
            int codFuncionario, horasTrabalhadas;
            float salario, valorHora;

            Console.WriteLine("Digite o número do funcionário:");
            codFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas:");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora:");
            valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine
            (
                "NUMBER = {0}\n"
                + "SALARY = U$ {1}"
                , codFuncionario, salario.ToString("F2", CultureInfo.InvariantCulture)
            );
        }

        static void Exercicio5() 
        {
            int codPeca1, codPeca2, qtdPeca1, qtdPeca2;
            float valorUnitario1, valorUnitario2, valorTotal;


            Console.WriteLine("Digite o código da peça 1, quantidade de peças 1 e valor unitário da peça 1:\n"
                + "(Separados por espaço)");
            string[] vet0 = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite o código da peça 2, quantidade de peças 2 e valor unitário da peça 2:\n"
                + "(Separados por espaço)");
            string[] vet1 = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(vet0[0]);
            qtdPeca1 = int.Parse(vet0[1]);
            valorUnitario1 = float.Parse(vet0[2], CultureInfo.InvariantCulture);
            codPeca2 = int.Parse(vet1[0]);
            qtdPeca2 = int.Parse(vet1[1]);
            valorUnitario2 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

            valorTotal = (valorUnitario1 * qtdPeca1) + (valorUnitario2 * qtdPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }

        static void Exercicio6() 
        {
            double a, b, c, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            Console.WriteLine("Digite os 3 valores de cada lado separados por espaço:");
            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            areaCirculo = Math.Pow(c,2) * 3.14159;
            areaTrapezio = (a + b) / 2.0 * c;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine
            (
                "TRIANGULO: {0}\n"
                + "CIRCULO: {1}\n"
                + "TRAPEZIO: {2}\n"
                + "QUADRADO: {3}\n"
                + "RETANGULO: {4}\n"
                ,areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)
                ,areaCirculo.ToString("F3", CultureInfo.InvariantCulture)
                ,areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)
                ,areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)
                ,areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)
            );
        }

        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
        }
    }
}
