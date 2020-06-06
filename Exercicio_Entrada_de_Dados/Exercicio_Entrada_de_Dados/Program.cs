using System;
using System.Globalization;

namespace Exercicio_Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            byte quartos;
            float preco;

            string sobrenome;
            byte idade;
            float altura;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separado por espaço)");
            string[] vet = Console.ReadLine().Split(' ');
            sobrenome = vet[0];
            idade = byte.Parse(vet[1]);
            altura = float.Parse(vet[2]);

            Console.WriteLine("{0}\n"
                + "{1}\n"
                + "{2}\n"
                + "{3}\n"
                + "{4}\n"
                + "{5}\n"
                , nome, quartos, preco.ToString("F2", CultureInfo.InvariantCulture), sobrenome, idade, altura.ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}
