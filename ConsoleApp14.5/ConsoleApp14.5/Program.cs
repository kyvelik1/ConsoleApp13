using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._5
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 2, 4 },
            { 1, 7, 6, 8 },
            { 9, 0, 11, 10 },
            { 13, 14, 12, 15 },
            { 17, 16, 18, 19 }
        };

            ArraySorter sorter = new ArraySorter(array);
            Console.WriteLine("обычный массив:");
            sorter.PrintArray(array);

            int[,] sortedArray = sorter.SortByLastColumnDescending();
            Console.WriteLine("\nсортированный массив:");
            sorter.PrintArray(sortedArray);
        }
    }
}
