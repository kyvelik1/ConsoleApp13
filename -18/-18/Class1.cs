using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Class1
    {
        class LocalMaximaFinder
        {
            private int[] array;

            // Конструктор для инициализации массива
            public LocalMaximaFinder(int[] inputArray)
            {
                array = inputArray;
            }

            // Метод для подсчета локальных максимумов
            public int CountLocalMaxima()
            {
                int count = 0;

                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 9, 6, 3, 14, 5, 7, 4 }; // Пример массива

                // Создаем объект класса LocalMaximaFinder
                LocalMaximaFinder finder = new LocalMaximaFinder(array);

                // Вызываем метод для подсчета локальных максимумов
                int result = finder.CountLocalMaxima();

                // Выводим результат
                Console.WriteLine("Количество локальных максимумов: " + result);
            }
        }
    }
}
