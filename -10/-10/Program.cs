using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        
            static void Main()
            {
                int[] X = new int[17];
                double[] Y = new double[17];

                // Ввод массива X с клавиатуры
                Console.WriteLine("Введите 17 элементов массива X:");
                for (int i = 0; i < X.Length; i++)
                {
                    Console.Write($"X[{i}] = ");
                    X[i] = int.Parse(Console.ReadLine());
                }

                // Расчет массива Y
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

                // Упорядочивание массивов
                Array.Sort(Y); // По возрастанию
                Array.Sort(X, (a, b) => b.CompareTo(a)); // По убыванию

                // Формирование массива R
                var R = X.Where((x, index) => index % 2 == 0)
                         .Concat(Y.Where((y, index) => index % 2 == 0))
                         .ToArray();

                // Вывод результатов
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
}
