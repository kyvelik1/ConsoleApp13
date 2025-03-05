using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5
{
    

    class ArraySorter
    {
        private int[,] array;

        public ArraySorter(int[,] array)
        {
            this.array = array;
        }

        public void PrintArray()
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

        public void BubbleSort()
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

        public void InsertionSort()
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

        public void SelectionSort()
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

    class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 8 },
            { 1, 7, 4 },
            { 9, 2, 6 }
        };

            ArraySorter sorter = new ArraySorter(array);

            Console.WriteLine("Исходный массив:");
            sorter.PrintArray();

            Console.WriteLine("\nСортировка пузырьком:");
            sorter.BubbleSort();
            sorter.PrintArray();

            Console.WriteLine("\nСортировка вставкой:");
            sorter.InsertionSort();
            sorter.PrintArray();

            Console.WriteLine("\nСортировка выбором:");
            sorter.SelectionSort();
            sorter.PrintArray();
        }
    }
}
