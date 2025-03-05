using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Class1
    {

        public class BinaryToHexConverter
        {
            // Метод для проверки, является ли строка двоичным числом
            private bool IsBinary(string input)
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1')
                    {
                        return false;
                    }
                }
                return true;
            }

            // Метод для преобразования двоичного числа в шестнадцатеричное
            public string ConvertBinaryToHex(string binaryInput)
            {
                // Проверяем, является ли введенная строка двоичным числом
                if (!IsBinary(binaryInput))
                {
                    throw new FormatException("Ошибка: введено некорректное двоичное число.");
                }

                // Преобразуем двоичное число в десятичное
                long decimalValue = Convert.ToInt64(binaryInput, 2);

                // Преобразуем десятичное число в шестнадцатеричное и переводим в верхний регистр
                string hexValue = Convert.ToString(decimalValue, 16).ToUpper();

                return hexValue;
            }
        }

        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса BinaryToHexConverter
                BinaryToHexConverter converter = new BinaryToHexConverter();

                // Запрашиваем у пользователя ввод двоичного числа
                Console.WriteLine("Введите двоичное число: ");
                string binaryInput = Console.ReadLine();

                try
                {
                    // Преобразуем двоичное число в шестнадцатеричное
                    string hexValue = converter.ConvertBinaryToHex(binaryInput);
                    // Выводим результат
                    Console.WriteLine($"Шестнадцатеричное представление: {hexValue}");
                }
                catch (FormatException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное двоичное число
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
