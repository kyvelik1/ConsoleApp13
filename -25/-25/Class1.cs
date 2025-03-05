using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Class1
    {
        class ArraySorter
        {
            private int[] array;

            public ArraySorter(int size)
            {
                array = new int[size];
            }

            public void InputArray()
            {
                Console.WriteLine($"Введите {array.Length} целых чисел:");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }

            public void SortArray()
            {
                var negatives = array.Where(x => x < 0).OrderBy(x => x).ToArray();
                var positives = array.Where(x => x > 0).OrderByDescending(x => x).ToArray();

                array = negatives.Concat(positives).ToArray();
            }

            public void PrintArray()
            {
                Console.WriteLine("Упорядоченный массив:");
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
                ArraySorter sorter = new ArraySorter(15);
                sorter.InputArray();
                sorter.SortArray();
                sorter.PrintArray();
            }
        }
    }
}
