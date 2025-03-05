using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] X;
            private double[] Y;
            private double[] R;

            public ArrayProcessor()
            {
                X = new int[17];
                Y = new double[17];
            }

            public void InputArrayX()
            {
                Console.WriteLine("Введите 17 элементов массива X:");
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
                    if (Math.Cos(X[i]) > 0)
                    {
                        Y[i] = Math.Pow(X[i], 3) - 7.5;
                    }
                    else
                    {
                        Y[i] = Math.Pow(X[i], 2) - 5 * Math.Exp(Math.Sin(X[i]));
                    }
                }
            }

            public void SortArrays()
            {
                Array.Sort(Y); // Сортировка Y по возрастанию
                Array.Sort(X, (a, b) => b.CompareTo(a)); // Сортировка X по убыванию
            }

            public void FormArrayR()
            {
                var evenIndexX = X.Where((x, index) => index % 2 == 0);
                var evenIndexY = Y.Where((y, index) => index % 2 == 0);
                R = evenIndexX.Concat(evenIndexY).ToArray();
            }

            public void PrintResults()
            {
                Console.WriteLine("\nМассив Y:");
                for (int i = 0; i < Y.Length; i++)
                {
                    Console.WriteLine($"Y[{i}] = {Y[i]:F4}");
                }

                Console.WriteLine("\nУпорядоченный массив X по убыванию:");
                for (int i = 0; i < X.Length; i++)
                {
                    Console.WriteLine($"X[{i}] = {X[i]}");
                }

                Console.WriteLine("\nМассив R (четные по индексу элементы X и Y):");
                for (int i = 0; i < R.Length; i++)
                {
                    Console.WriteLine($"R[{i}] = {R[i]:F4}");
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
                processor.SortArrays();
                processor.FormArrayR();
                processor.PrintResults();
            }
        }
    }
}
