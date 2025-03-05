using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Class1
    {
        class ArrayProcessor
        {
            private double[] array1;
            private double[] array2;

            public ArrayProcessor(double[] arr1, double[] arr2)
            {
                array1 = arr1;
                array2 = arr2;
            }

            public void FindAndSwapMaxElements()
            {
                int maxIndex1 = FindMaxIndex(array1);
                int maxIndex2 = FindMaxIndex(array2);

                Console.WriteLine("Исходный массив 1:");
                PrintArray(array1);
                Console.WriteLine("Исходный массив 2:");
                PrintArray(array2);

                SwapMaxElements(maxIndex1, maxIndex2);

                Console.WriteLine("Массив 1 после обмена:");
                PrintArray(array1);
                Console.WriteLine("Массив 2 после обмена:");
                PrintArray(array2);
            }

            private int FindMaxIndex(double[] array)
            {
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }

            private void SwapMaxElements(int maxIndex1, int maxIndex2)
            {
                double temp = array1[maxIndex1];
                array1[maxIndex1] = array2[maxIndex2];
                array2[maxIndex2] = temp;
            }

            private void PrintArray(double[] array)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                double[] array1 = { 3.5, 7.2, 1.8, 9.4, 5.6 };
                double[] array2 = { 2.1, 4.7, 6.3, 8.9, 0.5 };

                ArrayProcessor processor = new ArrayProcessor(array1, array2);
                processor.FindAndSwapMaxElements();
            }
        }
    }
}
