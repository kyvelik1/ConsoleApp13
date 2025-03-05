using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Class1
    {
        class ArrayProcessor
        {
            private int[] array;

            public ArrayProcessor(int[] inputArray)
            {
                if (inputArray.Length != 10)
                {
                    throw new ArgumentException("Массив должен содержать ровно 10 элементов.");
                }
                array = inputArray;
            }

            public int[] ProcessArray()
            {
                var negativeAndZero = array.Where(x => x <= 0).ToArray();
                var positive = array.Where(x => x > 0).ToArray();

                int[] result = new int[10];
                negativeAndZero.CopyTo(result, 0);
                positive.CopyTo(result, negativeAndZero.Length);

                return result;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = new int[10];
                Console.WriteLine("Введите 10 целых чисел:");
                for (int i = 0; i < 10; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                ArrayProcessor processor = new ArrayProcessor(array);
                int[] result = processor.ProcessArray();

                Console.WriteLine("Результат:");
                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
