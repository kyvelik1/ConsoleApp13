using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            {5, 4, 3, 2, 1, 6, 7, 8, 9, 10},
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
            {10, 9, 8, 7, 6, 5, 4, 3, 2, 1},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2}
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int count = 0;

            for (int j = 0; j < cols; j++)
            {
                bool isMonotonic = true;
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] >= matrix[i - 1, j])
                    {
                        isMonotonic = false;
                        break;
                    }
                }
                if (isMonotonic)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество столбцов с монотонно убывающими элементами: " + count);
        }
    }
}
