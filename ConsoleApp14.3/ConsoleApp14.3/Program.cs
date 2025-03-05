using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._3
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 1, -2, 3, -4, 5, -6 },
            { 7, -8, 9, -10, 11, -12 },
            { 13, -14, 15, -16, 17, -18 },
            { 19, -20, 21, -22, 23, -24 },
            { 25, -26, 27, -28, 29, -30 }
        };

            ArrayProcessor processor = new ArrayProcessor(array);
            Console.WriteLine("обычный массив:");
            processor.PrintArray();

            double[] averages = processor.CalculateAverageOfPositiveElementsPerColumn();
            Console.WriteLine("\nсредне арифмитическая стобцов:");
            for (int j = 0; j < averages.Length; j++)
            {
                Console.WriteLine($"Column {j + 1}: {averages[j]:F2}");
            }
        }
    }
}
