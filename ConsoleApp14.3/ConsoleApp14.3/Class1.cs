using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._3
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 5 || array.GetLength(1) != 6)
            {
                throw new ArgumentException("Array must be of size 5x6.");
            }

            this.array = array;
        }

        public double[] CalculateAverageOfPositiveElementsPerColumn()
        {
            double[] averages = new double[array.GetLength(1)];
            int[] counts = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                        count++;
                    }
                }

                if (count > 0)
                {
                    averages[j] = sum / count;
                }
                else
                {
                    averages[j] = 0; 
                }
            }

            return averages;
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
