using System;
using System.Collections.Generic;
using System.Text;

namespace Correcao_Exercicios_Fixacao
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantiaDolar, double cotacaoDolar) 
        {
            double totalReal = quantiaDolar * cotacaoDolar;
            return totalReal + totalReal *  Iof / 100.0;
        }
    }
}
