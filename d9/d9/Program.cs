using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d9
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

            // Создаем массив для хранения последних элементов строк и их индексов
            int[] lastElements = new int[n];
            int[] indices = new int[n];

            for (int i = 0; i < n; i++)
            {
                lastElements[i] = matrix[i, n - 1];
                indices[i] = i;
            }

            // Сортировка подсчетом
            int max = lastElements[0];
            for (int i = 1; i < n; i++)
            {
                if (lastElements[i] > max)
                    max = lastElements[i];
            }

            int[] count = new int[max + 1];

            for (int i = 0; i < n; i++)
            {
                count[lastElements[i]]++;
            }

            for (int i = max - 1; i >= 0; i--)
            {
                count[i] += count[i + 1];
            }

            int[] sortedIndices = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                sortedIndices[count[lastElements[i]] - 1] = indices[i];
                count[lastElements[i]]--;
            }

            // Перестановка строк матрицы
            int[,] sortedMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sortedMatrix[i, j] = matrix[sortedIndices[i], j];
                }
            }

            // Вывод отсортированной матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sortedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
