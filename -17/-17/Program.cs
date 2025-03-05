using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
       
            static void Main()
            {
                int[] array = { 9, 6, 3, 14, 5, 7, 4 }; // Пример массива
                int count = 0;

                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i - 1] && array[i] < array[i + 1])
                    {
                        count++;
                    }
                }

                Console.WriteLine("Количество локальных минимумов: " + count);
            }
        
    }
}
