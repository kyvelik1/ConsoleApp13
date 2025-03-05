using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива

            double average = array.Average();
            int count = array.Count(x => x > average);
            double percentage = (double)count / array.Length * 100;

            Console.WriteLine($"Процент элементов, превышающих среднее арифметическое: {percentage}%");
        }
    }
}
