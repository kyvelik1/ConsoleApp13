using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._6
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("обычная матрица:");
            processor.PrintMatrix();

            processor.SwapMaxElementsInFirstAndThirdColumns();
            Console.WriteLine("\nматрица после смены мест числами:");
            processor.PrintMatrix();
        }
    }
}
