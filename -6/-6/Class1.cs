using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Class1
    {

        class ArrayCalculator
        {
            private double[] arrayY;
            private int size;

            public ArrayCalculator(int size)
            {
                this.size = size;
                arrayY = new double[size];
            }

            public void CalculateArray()
            {
                // Расчет значений массива Y по формуле
                for (int i = 0; i < size; i++)
                {
                    arrayY[i] = Math.Pow(i, 2) - 2 * i + 19.3 * Math.Cos(i);
                }
            }

            public double[] GetOriginalArray()
            {
                return arrayY;
            }

            public double[] GetReorderedArray()
            {
                // Вычисление среднего арифметического
                double average = arrayY.Average();

                // Формирование нового массива
                var lessThanAverage = arrayY.Where(x => x < average).ToArray();
                var greaterOrEqualAverage = arrayY.Where(x => x >= average).ToArray();
                return lessThanAverage.Concat(greaterOrEqualAverage).ToArray();
            }

            public void PrintArray(double[] array, string message)
            {
                Console.WriteLine(message);
                foreach (var item in array)
                {
                    Console.Write($"{item:F2} "); // Форматирование до двух знаков после запятой
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                // Создание объекта класса ArrayCalculator
                ArrayCalculator calculator = new ArrayCalculator(12);

                // Расчет значений массива Y
                calculator.CalculateArray();

                // Получение и вывод исходного массива
                double[] originalArray = calculator.GetOriginalArray();
                calculator.PrintArray(originalArray, "Исходный массив Y:");

                // Получение и вывод нового массива
                double[] reorderedArray = calculator.GetReorderedArray();
                calculator.PrintArray(reorderedArray, "Новый массив (сначала элементы меньше среднего, затем остальные):");
            }
        }
    }
}
