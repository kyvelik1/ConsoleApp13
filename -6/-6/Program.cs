using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Размер массива
                int size = 12;
                double[] arrayY = new double[size];

                // Расчет значений массива Y по формуле
                for (int i = 0; i < size; i++)
                {
                    arrayY[i] = Math.Pow(i, 2) - 2 * i + 19.3 * Math.Cos(i);
                }

                // Вывод исходного массива Y
                Console.WriteLine("Исходный массив Y:");
                foreach (var item in arrayY)
                {
                    Console.Write($"{item:F2} "); // Форматирование до двух знаков после запятой
                }
                Console.WriteLine();

                // Вычисление среднего арифметического
                double average = arrayY.Average();

                // Формирование нового массива
                var lessThanAverage = arrayY.Where(x => x < average).ToArray();
                var greaterOrEqualAverage = arrayY.Where(x => x >= average).ToArray();
                double[] newArray = lessThanAverage.Concat(greaterOrEqualAverage).ToArray();

                // Вывод нового массива
                Console.WriteLine("Новый массив (сначала элементы меньше среднего, затем остальные):");
                foreach (var item in newArray)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine();
            
        }
    }
}
