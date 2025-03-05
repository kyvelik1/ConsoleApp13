using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8
{
    class MatrixProcessor
    {
        private int[,,] array;

        public MatrixProcessor(int[,,] inputArray)
        {
            array = inputArray;
        }

        public int FindMinRowSum()
        {
            int minSum = int.MaxValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        sum += array[i, j, k];
                    }

                    if (sum < minSum)
                    {
                        minSum = sum;
                    }
                }
            }

            return minSum;
        }

        public void MultiplyByMinSum(int minSum)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] *= minSum;
                    }
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

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

            MatrixProcessor processor = new MatrixProcessor(array);

            int minSum = processor.FindMinRowSum();
            Console.WriteLine("Минимальная сумма строки: " + minSum);

            processor.MultiplyByMinSum(minSum);
            Console.WriteLine("Матрица после умножения на минимальную сумму:");
            processor.PrintMatrix();
        }
    }
}
