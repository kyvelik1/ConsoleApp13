using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Class1
    {
        class MonotonicSequenceCounter
        {
            private int[] array;

            public MonotonicSequenceCounter(int[] inputArray)
            {
                array = inputArray;
            }

            public int CountIncreasingSequences()
            {
                int count = 0;
                bool inIncreasingSequence = false;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[i - 1])
                    {
                        if (!inIncreasingSequence)
                        {
                            inIncreasingSequence = true;
                            count++;
                        }
                    }
                    else
                    {
                        inIncreasingSequence = false;
                    }
                }

                return count;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] array = { 1, 2, 3, 1, 2, 3, 4, 1, 2 };
                MonotonicSequenceCounter counter = new MonotonicSequenceCounter(array);
                int result = counter.CountIncreasingSequences();

                Console.WriteLine("Количество участков с монотонно возрастающими элементами: " + result);
            }
        }
    }
}
