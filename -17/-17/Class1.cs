using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Class1
    {
        class LocalMinimaFinder
        {
            private int[] array;

            // Конструктор для инициализации массива
            public LocalMinimaFinder(int[] inputArray)
            {
                array = inputArray;
            }

            // Метод для подсчета локальных минимумов
            public int CountLocalMinima()
            {
                int count = 0;

                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i - 1] && array[i] < array[i + 1])
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

                // Создаем объект класса LocalMinimaFinder
                LocalMinimaFinder finder = new LocalMinimaFinder(array);

                // Вызываем метод для подсчета локальных минимумов
                int result = finder.CountLocalMinima();

                // Выводим результат
                Console.WriteLine("Количество локальных минимумов: " + result);
            }
        }
    }
}
