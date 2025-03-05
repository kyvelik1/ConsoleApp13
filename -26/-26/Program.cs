using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main()
        {
            // Инициализация двух массивов
            double[] array1 = { 1.2, 3.4, 5.6, 7.8, 9.0, 2.3, 4.5, 6.7, 8.9, 0.1, 1.3, 3.5 };
            double[] array2 = { 2.3, 4.5, 6.7, 8.9, 0.1, 1.3, 3.5, 5.6, 7.8, 9.0, 1.2, 3.4 };

            // Замена элементов первого массива нулями, если они есть во втором массиве
            for (int i = 0; i < array1.Length; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    array1[i] = 0;
                }
            }

            // Вывод результата
            Console.WriteLine("Результат:");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
        }
    }
}
