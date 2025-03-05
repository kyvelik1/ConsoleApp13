using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                // Ввод первого массива X из 10 элементов
                int[] arrayX = new int[10];
                Console.WriteLine("Введите 10 целых чисел для массива X:");
                for (int i = 0; i < 10; i++)
                {
                    arrayX[i] = int.Parse(Console.ReadLine());
                }

                // Ввод второго массива Y из 10 элементов
                int[] arrayY = new int[10];
                Console.WriteLine("Введите 10 целых чисел для массива Y:");
                for (int i = 0; i < 10; i++)
                {
                    arrayY[i] = int.Parse(Console.ReadLine());
                }

                // Поиск одинаковых элементов в массивах X и Y
                var commonElements = arrayX.Intersect(arrayY).ToArray();

                // Формирование массива S из одинаковых элементов
                int[] arrayS = commonElements;

                // Вывод результата
                Console.WriteLine("Массив S, состоящий из одинаковых элементов массивов X и Y:");
                foreach (var item in arrayS)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            
        }
    }
}
