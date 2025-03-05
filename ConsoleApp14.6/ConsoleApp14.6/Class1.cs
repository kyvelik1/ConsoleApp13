using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._6
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            if (matrix.GetLength(0) != 4 || matrix.GetLength(1) != 3)
            {
                throw new ArgumentException("Matrix must be of size 4x3.");
            }

            this.matrix = matrix;
        }

        public void SwapMaxElementsInFirstAndThirdColumns()
        {
            int maxFirstColIndex = FindMaxElementIndexInColumn(0);
            int maxThirdColIndex = FindMaxElementIndexInColumn(2);

            int temp = matrix[maxFirstColIndex, 0];
            matrix[maxFirstColIndex, 0] = matrix[maxThirdColIndex, 2];
            matrix[maxThirdColIndex, 2] = temp;
        }

        private int FindMaxElementIndexInColumn(int column)
        {
            int maxIndex = 0;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, column] > matrix[maxIndex, column])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
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
