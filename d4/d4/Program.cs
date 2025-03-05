using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4
{

    class Program
    {
        static void Main()
        {
            // Пример квадратной матрицы
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            int n = matrix.GetLength(0);
            int[] array = new int[n * (n - 1) / 2];
            int index = 0;

            // Формируем одномерный массив из элементов ниже главной диагонали
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    array[index++] = matrix[i, j];
                }
            }

            // Выводим матрицу
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Выводим одномерный массив до сортировки
            Console.WriteLine("\nОдномерный массив до сортировки:");
            Console.WriteLine(string.Join(" ", array));

            // Сортируем одномерный массив
            Array.Sort(array);

            // Выводим одномерный массив после сортировки
            Console.WriteLine("\nОдномерный массив после сортировки:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
