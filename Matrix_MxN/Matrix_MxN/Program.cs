using System;

namespace Matrix_MxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, number;
            int[,] resultMatrix;
            Matrix matrix;

            Console.Write("Enter the number of lines: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            n = int.Parse(Console.ReadLine());

            matrix = new Matrix(m, n);

            resultMatrix = matrix.ReadMatrix();

            Console.Write("Enter an integer: ");
            number = int.Parse(Console.ReadLine());

            matrix.PositionMatrix(resultMatrix, number);


        }
    }
}
