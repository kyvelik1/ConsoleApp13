using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] arrayX;
            private int[] arrayY;

            public ArrayProcessor(int size)
            {
                arrayX = new int[size];
                arrayY = new int[size];
            }

            public void InputArrays()
            {
                Console.WriteLine("Введите {0} целых чисел для массива X:", arrayX.Length);
                for (int i = 0; i < arrayX.Length; i++)
                {
                    arrayX[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введите {0} целых чисел для массива Y:", arrayY.Length);
                for (int i = 0; i < arrayY.Length; i++)
                {
                    arrayY[i] = int.Parse(Console.ReadLine());
                }
            }

            public int[] FindCommonElements()
            {
                // Находим пересечение элементов массивов X и Y
                return arrayX.Intersect(arrayY).ToArray();
            }

            public void PrintArray(int[] array, string message)
            {
                Console.WriteLine(message);
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
                // Создание объекта класса ArrayProcessor
                ArrayProcessor processor = new ArrayProcessor(10);

                // Ввод данных
                processor.InputArrays();

                // Поиск одинаковых элементов
                int[] commonElements = processor.FindCommonElements();

                // Вывод результата
                processor.PrintArray(commonElements, "Массив S, состоящий из одинаковых элементов массивов X и Y:");
            }
        }
    }
}
