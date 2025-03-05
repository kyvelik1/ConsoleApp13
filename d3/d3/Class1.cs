using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3
{
    class RandomArrayProcessor
    {
        private int[,] array;
        private int size;

        public RandomArrayProcessor(int size)
        {
            this.size = size;
            array = new int[size, size];
        }

        public void FillArrayWithRandomNumbers(int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public void ProcessArray()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = -array[i, j] * 3;
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            int size = 5; // Размер массива
            RandomArrayProcessor processor = new RandomArrayProcessor(size);

            processor.FillArrayWithRandomNumbers(-100, 100); // Заполнение массива случайными числами
            processor.ProcessArray(); // Обработка массива
            processor.PrintArray(); // Вывод массива на экран
        }
    }
}
