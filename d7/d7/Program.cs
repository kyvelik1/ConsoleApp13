using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d7
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

            int k = 7; // Значение, которое мы ищем
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                // Добавляем барьер в конец строки
                int[] rowWithBarrier = new int[cols + 1];
                for (int j = 0; j < cols; j++)
                {
                    rowWithBarrier[j] = matrix[i, j];
                }
                rowWithBarrier[cols] = k; // Барьер

                int j = 0;
                while (rowWithBarrier[j] != k)
                {
                    j++;
                }

                if (j < cols) // Если нашли элемент до барьера
                {
                    Console.WriteLine($"Элемент {k} найден в строке {i} на позиции {j}");
                }
                else
                {
                    Console.WriteLine($"Элемент {k} не найден в строке {i}");
                }
            }
        }
    }
}
