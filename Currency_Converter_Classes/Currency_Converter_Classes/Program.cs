using System;
using System.Globalization;

namespace Currency_Converter_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the dollar quote ? ");
            double dollarExchange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("How many dollars will you buy ? ");
            double dollarAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double realValue = CurrencyConverter.DollartoReal(dollarExchange, dollarAmount);

            Console.WriteLine("Amount to be paid in reais = = R$" + realValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
