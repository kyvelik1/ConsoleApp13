using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива

            int sumEven = 0; // Сумма элементов с четными индексами
            int sumOdd = 0;  // Сумма элементов с нечетными индексами

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += array[i];
                }
                else
                {
                    sumOdd += array[i];
                }
            }

            if (sumOdd == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
            }
            else
            {
                int remainder = sumEven % sumOdd;
                Console.WriteLine("Остаток от деления: " + remainder);
            }
        }
    }
}
