using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Class1
    {
        class FurthestElementFinder
        {
            private double[] array;
            private double S;

            public FurthestElementFinder(double[] array, double S)
            {
                this.array = array;
                this.S = S;
            }

            public (double Value, int Index) FindFurthestElement()
            {
                double maxDistance = 0;
                int maxIndex = 0;
                double maxValue = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    double distance = Math.Abs(array[i] - S);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        maxIndex = i;
                        maxValue = array[i];
                    }
                }

                return (maxValue, maxIndex);
            }
        }

        class Program
        {
            static void Main()
            {
                double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0 }; // Пример массива
                double S = 4.5; // Заданное число

                FurthestElementFinder finder = new FurthestElementFinder(array, S);
                var result = finder.FindFurthestElement();

                Console.WriteLine($"Элемент, наиболее удаленный от {S}:");
                Console.WriteLine($"Значение: {result.Value}, Индекс: {result.Index}");
            }
        }
    }
}
