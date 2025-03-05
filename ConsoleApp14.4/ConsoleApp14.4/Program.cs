using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._4
{
    internal class Program
    {
        static void Main()
        {
            double[,] matrix = {
            { 1.2, 2.3, 3.4, 4.5, 5.6 },
            { 6.7, 7.8, 8.9, 9.1, 1.2 },
            { 2.3, 3.4, 4.5, 5.6, 6.7 },
            { 7.8, 8.9, 9.1, 1.2, 2.3 },
            { 3.4, 4.5, 5.6, 6.7, 7.8 }
        };

            MatrixProcessor processor = new MatrixProcessor(matrix);
            Console.WriteLine("обычная матрицы:");
            processor.PrintMatrix();

            double minElement = processor.FindMinElementOnSecondaryDiagonal();
            Console.WriteLine($"\nминиммальный элемент на побочной диагонали: {minElement}");
        }
    }
}
