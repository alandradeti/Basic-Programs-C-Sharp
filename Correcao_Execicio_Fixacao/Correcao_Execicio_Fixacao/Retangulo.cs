using System;
using System.Collections.Generic;
using System.Text;

namespace Correcao_Execicio_Fixacao
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() 
        {    
            return (Largura * Altura);
        }

        public double Perimetro() 
        {
            return (Altura * 2 + Largura * 2);
        }

        public double Diagonal() 
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2)); ;
        }
    }
}
