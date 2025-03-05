using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d12
{

    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            int maxElement = FindMaxInOrderedColumns(matrix);
            Console.WriteLine("Максимальный элемент в упорядоченных столбцах: " + maxElement);
        }

        static int FindMaxInOrderedColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxElement = 0;

            for (int col = 0; col < cols; col++)
            {
                bool isAscending = true;
                bool isDescending = true;

                for (int row = 1; row < rows; row++)
                {
                    if (matrix[row, col] > matrix[row - 1, col])
                    {
                        isDescending = false;
                    }
                    if (matrix[row, col] < matrix[row - 1, col])
                    {
                        isAscending = false;
                    }
                }

                if (isAscending || isDescending)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        if (matrix[row, col] > maxElement)
                        {
                            maxElement = matrix[row, col];
                        }
                    }
                }
            }

            return maxElement;
        }
    }
    
}
