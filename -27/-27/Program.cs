using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 1, 2, 3, 4, 1, 2 };
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

            Console.WriteLine("Количество участков с монотонно возрастающими элементами: " + count);
        }
    }
}
