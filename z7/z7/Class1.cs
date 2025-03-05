using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z7
{
    class Class1
    {
        // Класс для работы с числами
        public class NumberProcessor
        {
            // Метод для изменения разрядности цифр в двузначном числе
            public int SwapDigits(int number)
            {
                if (number < 10 || number > 99)
                {
                    throw new ArgumentException("Число должно быть двузначным.");
                }

                int tens = number / 10; // Получаем десятки
                int units = number % 10; // Получаем единицы
                return units * 10 + tens; // Меняем разрядность
            }
        }

        // Класс для работы с массивами
        public class ArrayProcessor
        {
            private NumberProcessor _numberProcessor;

            public ArrayProcessor()
            {
                _numberProcessor = new NumberProcessor();
            }

            // Метод для изменения разрядности цифр в массиве
            public int[] SwapDigitsInArray(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = _numberProcessor.SwapDigits(array[i]);
                }
                return newArray;
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayProcessor
                ArrayProcessor arrayProcessor = new ArrayProcessor();

                // Ввод массива из 15 двузначных целых чисел
                int[] originalArray = new int[15];
                Console.WriteLine("Введите 15 двузначных целых чисел:");

                for (int i = 0; i < 15; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    originalArray[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    // Изменение разрядности цифр в массиве
                    int[] newArray = arrayProcessor.SwapDigitsInArray(originalArray);

                    // Вывод нового массива
                    Console.WriteLine("Новый массив:");
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        Console.Write($"{newArray[i]} ");
                    }
                }
                catch (ArgumentException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное число
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
