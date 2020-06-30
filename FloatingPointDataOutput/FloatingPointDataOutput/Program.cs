using System;
using System.Globalization;

namespace FloatingPointDataOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstProduct = "computer";
            string secondProduct = "work-table";

            byte age = 30;
            int code = 5290;
            char genre = 'M';

            double firstPrice = 2100.0;
            double secondPrice = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products: \n"
                + "{0}, whose price is R $ {1: F2} \n"
                + "{2}, whose price is R $ {3: F2} \n\n"
                + "Registration: {4} years old, code {5} and gender: {6} \n\n"
                + "Measured to other decimal places: {7} \n"
                + "Rounded (to three decimal places): {7:F3} \n"
                + "Invariant culture decimal separator:" + measure.ToString("F3", CultureInfo.InvariantCulture)
                , firstProduct, firstPrice, secondProduct, secondPrice, age, code, genre, measure);
        }
    }
}
