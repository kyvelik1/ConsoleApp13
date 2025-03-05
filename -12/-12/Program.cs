using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        
            static void Main()
            {
                double[] array = new double[12];
                int swapCount = 0;

                // Ввод массива
                Console.WriteLine("Введите 12 элементов массива:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = double.Parse(Console.ReadLine());
                }

                // Сортировка массива по убыванию с подсчетом перестановок
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            double temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                            swapCount++;
                        }
                    }
                }

                // Вывод результатов
                Console.WriteLine("\nОтсортированный массив по убыванию:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine($"\n\nКоличество перестановок: {swapCount}");
            }
        
    }
}
