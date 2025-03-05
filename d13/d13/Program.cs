using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13
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

            int n = matrix.GetLength(0);

            // Зеркальное отражение относительно побочной диагонали
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[n - j - 1, n - i - 1];
                    matrix[n - j - 1, n - i - 1] = temp;
                }
            }

            // Вывод результата
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
