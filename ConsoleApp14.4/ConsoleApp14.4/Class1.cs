using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._4
{
    class MatrixProcessor
    {
        private double[,] matrix;

        public MatrixProcessor(double[,] matrix)
        {
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
            {
                throw new ArgumentException("Matrix must be of size 5x5.");
            }

            this.matrix = matrix;
        }

        public double FindMinElementOnSecondaryDiagonal()
        {
            double minElement = double.MaxValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int j = matrix.GetLength(1) - 1 - i;
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                }
            }

            return minElement;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
