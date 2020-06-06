using System;
using System.Globalization;

namespace Exercicio_Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n"
                + "{0}, cujo preço é R$ {1:F2}\n"
                + "{2}, cujo preco é R$ {3:F2}\n\n"
                + "Registro: {4} anos de idade, código {5} e gênero: {6}\n\n"
                + "Medida com outo casas decimais: {7}\n"
                + "Arredondado (três casas decimais): {7:F3}\n"
                + "Separador decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture)
                , produto1, preco1, produto2, preco2, idade, codigo, genero, medida);
        }
    }
}
