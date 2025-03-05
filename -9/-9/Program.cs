using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int[] X = new int[15];
                double[] Y = new double[15];

                // Ввод массива X с клавиатуры
                Console.WriteLine("Введите 15 элементов массива X:");
                for (int i = 0; i < X.Length; i++)
                {
                    Console.Write($"X[{i}] = ");
                    X[i] = int.Parse(Console.ReadLine());
                }

                // Расчет массива Y
                for (int i = 0; i < Y.Length; i++)
                {
                    double xSquared = Math.Pow(X[i], 2);
                    double logTerm = Math.Pow(Math.Log10(i + 1), 2); // i+1, чтобы избежать log(0)
                    Y[i] = Math.Cos(xSquared) + 2.971 * logTerm;
                }

                // Объединение и сортировка массивов X и Y
                var combinedArray = X.Select(x => (double)x).Concat(Y).OrderByDescending(v => v).ToArray();

                // Вывод результатов
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
}
