using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Class1
    {
        class MaxOddPositiveFinder
        {
            private int[] array;

            public MaxOddPositiveFinder(int[] array)
            {
                this.array = array;
            }

            public int FindMaxOddPositiveIndex()
            {
                int maxIndex = -1;
                int maxValue = int.MinValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0 && array[i] % 2 != 0 && array[i] > maxValue)
                    {
                        maxValue = array[i];
                        maxIndex = i;
                    }
                }

                return maxIndex;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] R = new int[9] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }; // Пример массива

                MaxOddPositiveFinder finder = new MaxOddPositiveFinder(R);
                int result = finder.FindMaxOddPositiveIndex();

                if (result != -1)
                {
                    Console.WriteLine("Индекс наибольшего нечетного положительного элемента: " + result);
                }
                else
                {
                    Console.WriteLine("Нечетных положительных элементов в массиве нет.");
                }
            }
        }
    }
}
