using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d14
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 3, 1, 4 },
            { 2, 2, 5 },
            { 6, 3, 1 }
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Перемещаем минимальный элемент в первый столбец
                if (minIndex != 0)
                {
                    int temp = matrix[i, 0];
                    matrix[i, 0] = matrix[i, minIndex];
                    matrix[i, minIndex] = temp;
                }
            }

            // Выводим результат
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
