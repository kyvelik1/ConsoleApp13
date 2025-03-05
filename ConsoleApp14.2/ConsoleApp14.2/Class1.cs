using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._2
{
    class ArrayProcessor
    {
        private int[,] array;

        public ArrayProcessor(int[,] array)
        {
            if (array.GetLength(0) != 7 || array.GetLength(1) != 7)
            {
                throw new ArgumentException("массив должен быть размером 7х7.");
            }

            this.array = array;
        }

        public int SumOfAbsoluteNegativeOddElements()
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0 && array[i, j] % 2 != 0)
                    {
                        sum += Math.Abs(array[i, j]);
                    }
                }
            }

            return sum;
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
