using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Class1
    {
        class ArrayCombiner
        {
            private double[] array1;
            private double[] array2;

            public ArrayCombiner(int size1, int size2)
            {
                array1 = new double[size1];
                array2 = new double[size2];
            }

            public void InputArrays()
            {
                Console.WriteLine("Введите {0} действительных чисел для первого массива:", array1.Length);
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введите {0} действительных чисел для второго массива:", array2.Length);
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = double.Parse(Console.ReadLine());
                }
            }

            public double[] CombineAndSort()
            {
                // Объединение двух массивов
                double[] combinedArray = array1.Concat(array2).ToArray();

                // Сортировка объединенного массива по возрастанию
                Array.Sort(combinedArray);

                return combinedArray;
            }

            public void PrintArray(double[] array)
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
                // Создание объекта класса ArrayCombiner
                ArrayCombiner combiner = new ArrayCombiner(9, 7);

                // Ввод данных
                combiner.InputArrays();

                // Объединение и сортировка массивов
                double[] resultArray = combiner.CombineAndSort();

                // Вывод результата
                combiner.PrintArray(resultArray);
            }
        }
    }
}
