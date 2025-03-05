using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8
{
   

    class Program
    {
        static void Main()
        {
            int[,,] array = new int[4, 3, 3]
            {
            { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} },
            { {9, 8, 7}, {6, 5, 4}, {3, 2, 1} },
            { {2, 3, 4}, {5, 6, 7}, {8, 9, 10} },
            { {10, 9, 8}, {7, 6, 5}, {4, 3, 2} }
            };

            int minSum = int.MaxValue;
            int minSumIndex = -1;

            // Находим строку с минимальной суммой
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        sum += array[i, j, k];
                    }

                    if (sum < minSum)
                    {
                        minSum = sum;
                        minSumIndex = j;
                    }
                }
            }

            // Умножаем каждый элемент матрицы на минимальную сумму
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array[i, j, k] *= minSum;
                    }
                }
            }

            // Выводим результат
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
