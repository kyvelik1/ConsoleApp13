using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10
{
    class Program
    {
        // Класс для работы с массивами
        public class ArrayMerger
        {
            // Метод для объединения двух массивов и сортировки по убыванию
            public double[] MergeAndSort(double[] array1, double[] array2)
            {
                // Объединяем два массива
                double[] mergedArray = array1.Concat(array2).ToArray();

                // Сортируем объединенный массив по убыванию
                Array.Sort(mergedArray);
                Array.Reverse(mergedArray);

                return mergedArray;
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayMerger
                ArrayMerger arrayMerger = new ArrayMerger();

                // Ввод первого массива из 7 элементов
                double[] array1 = new double[7];
                Console.WriteLine("Введите 7 действительных чисел для первого массива:");

                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array1[i] = double.Parse(Console.ReadLine());
                }

                // Ввод второго массива из 9 элементов
                double[] array2 = new double[9];
                Console.WriteLine("Введите 9 действительных чисел для второго массива:");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array2[i] = double.Parse(Console.ReadLine());
                }

                // Объединение и сортировка массивов
                double[] mergedAndSortedArray = arrayMerger.MergeAndSort(array1, array2);

                // Вывод отсортированного массива
                Console.WriteLine("Отсортированный массив по убыванию:");
                for (int i = 0; i < mergedAndSortedArray.Length; i++)
                {
                    Console.Write($"{mergedAndSortedArray[i]} ");
                }
            }
        }
    }
}
