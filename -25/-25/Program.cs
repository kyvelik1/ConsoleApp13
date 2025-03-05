using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[15];
            Console.WriteLine("Введите 15 целых чисел:");

            for (int i = 0; i < 15; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Разделяем отрицательные и положительные числа
            var negatives = array.Where(x => x < 0).OrderBy(x => x).ToArray();
            var positives = array.Where(x => x > 0).OrderByDescending(x => x).ToArray();

            // Объединяем результаты
            var result = negatives.Concat(positives).ToArray();

            Console.WriteLine("Упорядоченный массив:");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

    }
}
