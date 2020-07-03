using System;
using System.Collections.Generic;
using System.Text;

namespace Currency_Converter_Classes
{
    class CurrencyConverter
    {
        public static double Iof = 6.0;

        public static double DollartoReal(double amountDollar, double dollarExchange) 
        {
            double realTotal = amountDollar * dollarExchange;
            return realTotal + realTotal *  Iof / 100.0;
        }
    }
}
