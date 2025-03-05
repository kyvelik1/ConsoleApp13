using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0 }; // Пример массива
            double S = 4.5; // Заданное число
            double maxDistance = 0;
            int maxIndex = 0;
            double maxValue = 0;

            // Поиск элемента, наиболее удаленного от S
            for (int i = 0; i < array.Length; i++)
            {
                double distance = Math.Abs(array[i] - S);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    maxIndex = i;
                    maxValue = array[i];
                }
            }

            // Вывод результатов
            Console.WriteLine($"Элемент, наиболее удаленный от {S}:");
            Console.WriteLine($"Значение: {maxValue}, Индекс: {maxIndex}");
        }
    }
}
