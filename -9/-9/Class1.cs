using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] X;
            private double[] Y;
            private double[] combinedArray;

            public ArrayProcessor()
            {
                X = new int[15];
                Y = new double[15];
            }

            public void InputArrayX()
            {
                Console.WriteLine("Введите 15 элементов массива X:");
                for (int i = 0; i < X.Length; i++)
                {
                    Console.Write($"X[{i}] = ");
                    X[i] = int.Parse(Console.ReadLine());
                }
            }

            public void CalculateArrayY()
            {
                for (int i = 0; i < Y.Length; i++)
                {
                    double xSquared = Math.Pow(X[i], 2);
                    double logTerm = Math.Pow(Math.Log10(i + 1), 2); // i+1, чтобы избежать log(0)
                    Y[i] = Math.Cos(xSquared) + 2.971 * logTerm;
                }
            }

            public void CombineAndSortArrays()
            {
                combinedArray = X.Select(x => (double)x).Concat(Y).OrderByDescending(v => v).ToArray();
            }

            public void PrintResults()
            {
                Console.WriteLine("\nМассив Y:");
                for (int i = 0; i < Y.Length; i++)
                {
                    Console.WriteLine($"Y[{i}] = {Y[i]:F4}");
                }

                Console.WriteLine("\nУпорядоченный массив:");
                for (int i = 0; i < combinedArray.Length; i++)
                {
                    Console.WriteLine($"[{i}] = {combinedArray[i]:F4}");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                ArrayProcessor processor = new ArrayProcessor();

                processor.InputArrayX();
                processor.CalculateArrayY();
                processor.CombineAndSortArrays();
                processor.PrintResults();
            }
        }
    }
}
