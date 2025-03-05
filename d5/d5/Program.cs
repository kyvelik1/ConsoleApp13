using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5
{
    class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 8 },
            { 1, 7, 4 },
            { 9, 2, 6 }
        };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Console.WriteLine("\nСортировка пузырьком:");
            BubbleSort(array);
            PrintArray(array);

            Console.WriteLine("\nСортировка вставкой:");
            InsertionSort(array);
            PrintArray(array);

            Console.WriteLine("\nСортировка выбором:");
            SelectionSort(array);
            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void BubbleSort(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int totalElements = rows * cols;

            for (int i = 0; i < totalElements - 1; i++)
            {
                for (int j = 0; j < totalElements - 1 - i; j++)
                {
                    int row1 = j / cols;
                    int col1 = j % cols;
                    int row2 = (j + 1) / cols;
                    int col2 = (j + 1) % cols;

                    if (array[row1, col1] > array[row2, col2])
                    {
                        int temp = array[row1, col1];
                        array[row1, col1] = array[row2, col2];
                        array[row2, col2] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int totalElements = rows * cols;

            for (int i = 1; i < totalElements; i++)
            {
                int current = array[i / cols, i % cols];
                int j = i - 1;

                while (j >= 0 && array[j / cols, j % cols] > current)
                {
                    array[(j + 1) / cols, (j + 1) % cols] = array[j / cols, j % cols];
                    j--;
                }

                array[(j + 1) / cols, (j + 1) % cols] = current;
            }
        }

        static void SelectionSort(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int totalElements = rows * cols;

            for (int i = 0; i < totalElements - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < totalElements; j++)
                {
                    if (array[j / cols, j % cols] < array[minIndex / cols, minIndex % cols])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i / cols, i % cols];
                    array[i / cols, i % cols] = array[minIndex / cols, minIndex % cols];
                    array[minIndex / cols, minIndex % cols] = temp;
                }
            }
        }
    }
}
