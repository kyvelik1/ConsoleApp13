using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
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

            var negativeAndZero = array.Where(x => x <= 0).ToArray();
            var positive = array.Where(x => x > 0).ToArray();

            int[] result = new int[10];
            negativeAndZero.CopyTo(result, 0);
            positive.CopyTo(result, negativeAndZero.Length);

            Console.WriteLine("Результат:");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
