using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
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

            public void ReplaceCommonElementsWithZero()
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array2.Contains(array1[i]))
                    {
                        array1[i] = 0;
                    }
                }
            }

            public void PrintArray1()
            {
                Console.WriteLine("Результат:");
                foreach (var item in array1)
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
                // Инициализация массивов
                double[] array1 = { 1.2, 3.4, 5.6, 7.8, 9.0, 2.3, 4.5, 6.7, 8.9, 0.1, 1.3, 3.5 };
                double[] array2 = { 2.3, 4.5, 6.7, 8.9, 0.1, 1.3, 3.5, 5.6, 7.8, 9.0, 1.2, 3.4 };

                // Создание объекта класса ArrayProcessor
                ArrayProcessor processor = new ArrayProcessor(array1, array2);

                // Замена общих элементов нулями
                processor.ReplaceCommonElementsWithZero();

                // Вывод результата
                processor.PrintArray1();
            }
        }

    }
}
