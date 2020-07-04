using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_MxN
{
    class Matrix
    { 

        public int Line { get; private set; }

        public int Column { get; private set; }

        public Matrix(int line, int column)
        {
            Line = line;
            Column = column;
        }

        //Performs the reading of the matrix and returns the resulting matrix
        public int[,] ReadMatrix()
        {
            int[,] matrix = new int[Line, Column];

            for (int l = 0; l < Line; l++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int c = 0; c < Column; c++)
                {
                    matrix[l, c] = int.Parse(values[c]);
                }
            }

            return matrix;
        }

        //Returns the position of the number entered in the matrix and the numbers around it
        public void PositionMatrix(int[,] matrix, int number)
        {
            for (int l = 0; l < Line; l++)
            {
                for (int c = 0; c < Column; c++)
                {
                    if (matrix[l, c] == number)
                    {
                        Console.WriteLine("Position: " + l + "," + c);

                        if (l > 0) Console.WriteLine("Up: " + matrix[l - 1, c]); //Print the number above the "number"
                        if (c > 0) Console.WriteLine("Left: " + matrix[l, c - 1]); //Print the number to the left of the "number"
                        if (c < Column - 1) Console.WriteLine("Right: " + matrix[l, c + 1]); //Print the number to the right of the "number"
                        if (l < Line - 1) Console.WriteLine("Down: " + matrix[l + 1, c]); //Print the number below the "number"
                    }
                }
            }
        }

    }
}
