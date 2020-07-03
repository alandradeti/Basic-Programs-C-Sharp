using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Structures
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Area() 
        {    
            return (Width * Height);
        }

        public double Perimeter() 
        {
            return (Height * 2 + Width * 2);
        }

        public double Diagonal() 
        {
            return Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2)); ;
        }
    }
}
