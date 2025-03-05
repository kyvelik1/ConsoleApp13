using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Запрашиваем у пользователя ввод двоичного числа
                Console.WriteLine("Введите двоичное число: ");
                string binaryString = Console.ReadLine();

                try
                {
                    // Преобразуем двоичное число в десятичное
                    int decimalNumber = ConvertBinaryToDecimal(binaryString);
                    // Выводим результат
                    Console.WriteLine($"Десятичное представление: {decimalNumber}");
                }
                catch (FormatException)
                {
                    // Обрабатываем ошибку, если введено некорректное двоичное число
                    Console.WriteLine("Ошибка: Введено некорректное двоичное число.");
                }
            }

            // Метод для преобразования двоичного числа в десятичное
            private static int ConvertBinaryToDecimal(string binary)
            {
                int decimalNumber = 0;

                // Проходим по каждому символу двоичного числа
                for (int i = 0; i < binary.Length; i++)
                {
                    // Проверяем, является ли текущий символ '1'
                    if (binary[binary.Length - 1 - i] == '1')
                    {
                        // Если да, добавляем соответствующую степень двойки к десятичному числу
                        decimalNumber += (1 << i);
                    }
                    // Проверяем, является ли текущий символ '0'
                    else if (binary[binary.Length - 1 - i] != '0')
                    {
                        // Если символ не '0' и не '1', выбрасываем исключение
                        throw new FormatException("Некорректный символ в двоичном числе.");
                    }
                }

                return decimalNumber;
            }
        }
    }
}
