using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Class1
    {
        class LocalMinFinder
        {
            private int[] array;

            public LocalMinFinder(int[] array)
            {
                this.array = array;
            }

            public int CountLocalMins()
            {
                int localMinCount = 0;

                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i - 1] && array[i] < array[i + 1])
                    {
                        localMinCount++;
                    }
                }

                return localMinCount;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 }; // Пример массива

                LocalMinFinder finder = new LocalMinFinder(array);
                int result = finder.CountLocalMins();

                Console.WriteLine($"Количество локальных минимумов: {result}");
            }
        }
    }
}
