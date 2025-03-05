using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] X = new int[10];
            private double[] Y = new double[10];
            private double P;
            private double remainder;

            public void InputArray()
            {
                Console.WriteLine("Введите 10 элементов массива X:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"X[{i}] = ");
                    X[i] = int.Parse(Console.ReadLine());
                }
            }

            public void CalculateY()
            {
                for (int i = 0; i < 10; i++)
                {
                    Y[i] = Math.Pow(X[i], 2) + 0.3;
                }
            }

            public void CalculateP()
            {
                double numerator = 1.0;
                double denominator = 1.0;

                for (int i = 1; i < 10; i += 2)
                {
                    numerator *= X[i] * Y[i];
                }

                for (int i = 0; i < 10; i += 2)
                {
                    denominator *= X[i] * Y[i];
                }

                P = numerator / denominator;
                remainder = P % 1;
            }

            public void DisplayResults()
            {
                Console.WriteLine("Массив Y:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Y[{i}] = {Y[i]}");
                }

                Console.WriteLine($"Значение P: {P}");
                Console.WriteLine($"Остаток от деления P на 1: {remainder}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ArrayProcessor processor = new ArrayProcessor();

                processor.InputArray();
                processor.CalculateY();
                processor.CalculateP();
                processor.DisplayResults();
            }
        }
    }
}
