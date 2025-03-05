using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод первого массива из 9 элементов
            double[] array1 = new double[9];
            Console.WriteLine("Введите 9 действительных чисел для первого массива:");
            for (int i = 0; i < 9; i++)
            {
                array1[i] = double.Parse(Console.ReadLine());
            }

            // Ввод второго массива из 7 элементов
            double[] array2 = new double[7];
            Console.WriteLine("Введите 7 действительных чисел для второго массива:");
            for (int i = 0; i < 7; i++)
            {
                array2[i] = double.Parse(Console.ReadLine());
            }

            // Объединение двух массивов
            double[] combinedArray = array1.Concat(array2).ToArray();

            // Сортировка объединенного массива по возрастанию
            Array.Sort(combinedArray);

            // Вывод результата
            Console.WriteLine("Упорядоченный массив:");
            foreach (var item in combinedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
