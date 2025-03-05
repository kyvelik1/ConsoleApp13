using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z7
{
    class Program
    {
        public class ArrayDigitSwapper
        {
            // Метод для изменения разрядности цифр в числе
            private int SwapDigits(int number)
            {
                int tens = number / 10; // Получаем десятки
                int units = number % 10; // Получаем единицы
                return units * 10 + tens; // Меняем разрядность
            }

            // Метод для изменения разрядности цифр в массиве
            public int[] SwapDigitsInArray(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = SwapDigits(array[i]);
                }
                return newArray;
            }
        }

        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayDigitSwapper
                ArrayDigitSwapper swapper = new ArrayDigitSwapper();

                // Ввод массива из 15 двузначных целых чисел
                int[] originalArray = new int[15];
                Console.WriteLine("Введите 15 двузначных целых чисел:");

                for (int i = 0; i < 15; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    originalArray[i] = int.Parse(Console.ReadLine());
                }

                // Изменение разрядности цифр в массиве
                int[] newArray = swapper.SwapDigitsInArray(originalArray);

                // Вывод нового массива
                Console.WriteLine("Новый массив:");
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write($"{newArray[i]} ");
                }
            }
        }
    }
}
