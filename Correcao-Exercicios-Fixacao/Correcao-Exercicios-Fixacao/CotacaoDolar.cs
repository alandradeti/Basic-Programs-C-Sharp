using System;
using System.Globalization;

namespace Correcao_Exercicios_Fixacao
{
    class CotacaoDolar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantiaDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorReal = ConversorDeMoeda.DolarParaReal(cotacaoDolar, quantiaDolar);

            Console.WriteLine("Valor a ser pago em reais = R$" + valorReal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
