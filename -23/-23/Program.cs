using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main()
        {
            // Ввод массива X
            int[] X = new int[10];
            Console.WriteLine("Введите 10 элементов массива X:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"X[{i}] = ");
                X[i] = int.Parse(Console.ReadLine());
            }

            // Вычисление массива Y
            double[] Y = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Y[i] = Math.Pow(X[i], 2) + 0.3;
            }

            // Вычисление P
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

            double P = numerator / denominator;

            // Определение остатка от деления
            double remainder = P % 1;

            // Вывод результатов
            Console.WriteLine($"Значение P: {P}");
            Console.WriteLine($"Остаток от деления P на 1: {remainder}");
        }
    }
}
