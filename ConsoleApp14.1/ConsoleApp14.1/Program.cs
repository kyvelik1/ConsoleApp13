using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._1
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = {
            { 5, 3, 2, 4 },
            { 1, 7, 6, 8 },
            { 9, 0, 11, 10 }
        };

            ArraySorter sorter = new ArraySorter(array);
            Console.WriteLine("обычный массив:");
            sorter.PrintArray(array);

            int[,] sortedArray = sorter.SortByLastRow();
            Console.WriteLine("\nсортированный массив:");
            sorter.PrintArray(sortedArray);
        }
    }
}
