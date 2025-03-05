using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] array;

            public ArrayProcessor(int[] inputArray)
            {
                array = inputArray;
            }

            public int CalculateRemainder()
            {
                int sumEven = 0; // Сумма элементов с четными индексами
                int sumOdd = 0;  // Сумма элементов с нечетными индексами

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += array[i];
                    }
                    else
                    {
                        sumOdd += array[i];
                    }
                }

                if (sumOdd == 0)
                {
                    throw new DivideByZeroException("Деление на ноль невозможно.");
                }

                return sumEven % sumOdd;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива

                ArrayProcessor processor = new ArrayProcessor(array);

                try
                {
                    int remainder = processor.CalculateRemainder();
                    Console.WriteLine("Остаток от деления: " + remainder);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
