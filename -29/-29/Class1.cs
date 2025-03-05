using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Class1
    {
        class ArrayAnalyzer
        {
            private int[] array;

            public ArrayAnalyzer(int[] array)
            {
                this.array = array;
            }

            public double CalculateAverage()
            {
                return array.Average();
            }

            public double CalculatePercentageAboveAverage()
            {
                double average = CalculateAverage();
                int count = array.Count(x => x > average);
                return (double)count / array.Length * 100;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива

                ArrayAnalyzer analyzer = new ArrayAnalyzer(array);
                double percentage = analyzer.CalculatePercentageAboveAverage();

                Console.WriteLine($"Процент элементов, превышающих среднее арифметическое: {percentage}%");
            }
        }
    }
}
