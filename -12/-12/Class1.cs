using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Class1
    {
        class ArraySorter
        {
            private double[] array;
            private int swapCount;

            public ArraySorter()
            {
                array = new double[12];
                swapCount = 0;
            }

            public void InputArray()
            {
                Console.WriteLine("Введите 12 элементов массива:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = double.Parse(Console.ReadLine());
                }
            }

            public void SortArrayDescending()
            {
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
            }

            public void PrintResults()
            {
                Console.WriteLine("\nОтсортированный массив по убыванию:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine($"\n\nКоличество перестановок: {swapCount}");
            }
        }

        class Program
        {
            static void Main()
            {
                ArraySorter sorter = new ArraySorter();

                sorter.InputArray();
                sorter.SortArrayDescending();
                sorter.PrintResults();
            }
        }
    }
}
