using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 3, 1, 4 },
            { 5, 9, 2 },
            { 6, 7, 8 }
        };

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int[] minElements = new int[n];
            int[] minIndices = new int[n];

            // Находим минимальные элементы в каждой строке и их индексы
            for (int i = 0; i < n; i++)
            {
                int minVal = matrix[i, 0];
                int minIndex = 0;
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] < minVal)
                    {
                        minVal = matrix[i, j];
                        minIndex = j;
                    }
                }
                minElements[i] = minVal;
                minIndices[i] = minIndex;
            }

            // Находим максимальный элемент среди минимальных
            int maxMinVal = minElements.Max();
            int maxMinIndex = Array.IndexOf(minElements, maxMinVal);

            // Выводим индексы найденного элемента
            Console.WriteLine($"Индексы элемента: [{maxMinIndex}, {minIndices[maxMinIndex]}]");
        }
    }
}
