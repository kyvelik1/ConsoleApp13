using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main()
        {
            // Ввод двух массивов действительных чисел
            double[] array1 = { 3.5, 7.2, 1.8, 9.4, 5.6 };
            double[] array2 = { 2.1, 4.7, 6.3, 8.9, 0.5 };

            // Нахождение максимальных элементов в каждом массиве
            int maxIndex1 = FindMaxIndex(array1);
            int maxIndex2 = FindMaxIndex(array2);

            // Вывод исходных массивов
            Console.WriteLine("Исходный массив 1:");
            PrintArray(array1);
            Console.WriteLine("Исходный массив 2:");
            PrintArray(array2);

            // Обмен максимальными элементами
            SwapMaxElements(array1, array2, maxIndex1, maxIndex2);

            // Вывод массивов после обмена
            Console.WriteLine("Массив 1 после обмена:");
            PrintArray(array1);
            Console.WriteLine("Массив 2 после обмена:");
            PrintArray(array2);
        }

        static int FindMaxIndex(double[] array)
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

        static void SwapMaxElements(double[] array1, double[] array2, int maxIndex1, int maxIndex2)
        {
            double temp = array1[maxIndex1];
            array1[maxIndex1] = array2[maxIndex2];
            array2[maxIndex2] = temp;
        }

        static void PrintArray(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
