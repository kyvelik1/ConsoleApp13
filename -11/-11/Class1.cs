using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Class1
    {
        class DigitSumProcessor
        {
            private int[] originalArray;
            private int[] sumArray;

            public DigitSumProcessor()
            {
                originalArray = new int[9];
                sumArray = new int[9];
            }

            public void InputArray()
            {
                Console.WriteLine("Введите 9 двузначных чисел:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    originalArray[i] = int.Parse(Console.ReadLine());
                    if (originalArray[i] < 10 || originalArray[i] > 99)
                    {
                        Console.WriteLine("Ошибка: введено не двузначное число. Пожалуйста, введите двузначное число.");
                        i--; // Повторяем ввод для текущего элемента
                    }
                }
            }

            public void CalculateSumArray()
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    int number = originalArray[i];
                    int sum = (number / 10) + (number % 10); // Сумма цифр
                    sumArray[i] = sum;
                }
            }

            public void PrintResults()
            {
                Console.WriteLine("\nИсходный массив:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write($"{originalArray[i]} ");
                }

                Console.WriteLine("\n\nМассив сумм цифр:");
                for (int i = 0; i < sumArray.Length; i++)
                {
                    Console.Write($"{sumArray[i]} ");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                DigitSumProcessor processor = new DigitSumProcessor();

                processor.InputArray();
                processor.CalculateSumArray();
                processor.PrintResults();
            }
        }
    }
}
