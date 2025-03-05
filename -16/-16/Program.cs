using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main()
        {
            int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 }; // Пример массива
            int localMinCount = 0;

            // Поиск локальных минимумов
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    localMinCount++;
                }
            }

            // Вывод результата
            Console.WriteLine($"Количество локальных минимумов: {localMinCount}");
        }
    }
}
