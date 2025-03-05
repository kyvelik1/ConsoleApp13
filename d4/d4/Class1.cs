using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4
{
    class MatrixProcessor
    {
        private int[,] matrix;

        public MatrixProcessor(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int[] GetElementsBelowMainDiagonal()
        {
            int n = matrix.GetLength(0);
            int[] array = new int[n * (n - 1) / 2];
            int index = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    array[index++] = matrix[i, j];
                }
            }

            return array;
        }

        public void PrintMatrix()
        {
            int n = matrix.GetLength(0);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrintArray(int[] array, string message)
        {
            Console.WriteLine($"\n{message}:");
            Console.WriteLine(string.Join(" ", array));
        }
    }

    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);

            // Выводим матрицу
            processor.PrintMatrix();

            // Получаем элементы ниже главной диагонали
            int[] array = processor.GetElementsBelowMainDiagonal();

            // Выводим одномерный массив до сортировки
            processor.PrintArray(array, "Одномерный массив до сортировки");

            // Сортируем одномерный массив
            Array.Sort(array);

            // Выводим одномерный массив после сортировки
            processor.PrintArray(array, "Одномерный массив после сортировки");
        }
    }
}
