using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int[] R = new int[9] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }; // Пример массива
                int maxIndex = -1;
                int maxValue = int.MinValue;

                for (int i = 0; i < R.Length; i++)
                {
                    if (R[i] > 0 && R[i] % 2 != 0 && R[i] > maxValue)
                    {
                        maxValue = R[i];
                        maxIndex = i;
                    }
                }

                if (maxIndex != -1)
                {
                    Console.WriteLine("Индекс наибольшего нечетного положительного элемента: " + maxIndex);
                }
                else
                {
                    Console.WriteLine("Нечетных положительных элементов в массиве нет.");
                }
            
        }
    }
}
