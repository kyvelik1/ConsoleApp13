using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Class1
    {
        // Класс для работы с двоичными числами
        public class BinaryNumber
        {
            // Проверка, является ли строка двоичным дробным числом
            public static bool IsBinaryFraction(string input)
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1' && c != '.')
                    {
                        return false;
                    }
                }
                return true;
            }

            // Преобразование целой части двоичного числа в десятичное
            public static double ConvertBinaryToDecimal(string binary)
            {
                double decimalValue = 0;
                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[binary.Length - 1 - i] == '1')
                    {
                        decimalValue += Math.Pow(2, i);
                    }
                }
                return decimalValue;
            }

            // Преобразование дробной части двоичного числа в десятичное
            public static double ConvertBinaryFractionToDecimal(string binaryFraction)
            {
                double decimalValue = 0;
                for (int i = 0; i < binaryFraction.Length; i++)
                {
                    if (binaryFraction[i] == '1')
                    {
                        decimalValue += Math.Pow(2, -(i + 1));
                    }
                }
                return decimalValue;
            }
        }

        // Класс для работы с восьмеричными числами
        public class OctalNumber
        {
            // Преобразование десятичного числа в восьмеричное
            public static string ConvertDecimalToOctal(double decimalValue)
            {
                // Разделяем число на целую и дробную части
                long integerPart = (long)decimalValue;
                double fractionalPart = decimalValue - integerPart;

                // Преобразуем целую часть в восьмеричное число
                string octalIntegerPart = Convert.ToString(integerPart, 8);

                // Преобразуем дробную часть в восьмеричное число
                string octalFractionalPart = "";
                while (fractionalPart > 0)
                {
                    fractionalPart *= 8;
                    int digit = (int)fractionalPart;
                    octalFractionalPart += digit.ToString();
                    fractionalPart -= digit;
                }

                // Возвращаем результат, объединяя целую и дробную части
                return octalFractionalPart.Length > 0 ? $"{octalIntegerPart}.{octalFractionalPart}" : octalIntegerPart;
            }
        }

        // Основной класс для преобразования двоичного числа в восьмеричное
        public class BinaryToOctalConverter
        {
            public string Convert(string binaryInput)
            {
                // Проверяем, является ли введенная строка двоичным дробным числом
                if (!BinaryNumber.IsBinaryFraction(binaryInput))
                {
                    throw new FormatException("Ошибка: введено некорректное двоичное дробное число.");
                }

                // Разделяем число на целую и дробную части
                string[] parts = binaryInput.Split('.');
                string integerPart = parts[0];
                string fractionalPart = parts.Length > 1 ? parts[1] : "0";

                // Преобразуем целую часть в десятичное число
                double decimalValue = BinaryNumber.ConvertBinaryToDecimal(integerPart);

                // Преобразуем дробную часть в десятичное число и добавляем к результату
                decimalValue += BinaryNumber.ConvertBinaryFractionToDecimal(fractionalPart);

                // Преобразуем десятичное число в восьмеричное
                return OctalNumber.ConvertDecimalToOctal(decimalValue);
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса BinaryToOctalConverter
                BinaryToOctalConverter converter = new BinaryToOctalConverter();

                // Запрашиваем у пользователя ввод двоичного дробного числа
                Console.Write("Введите двоичное дробное число (например, 101.101): ");
                string binaryInput = Console.ReadLine();

                try
                {
                    // Преобразуем двоичное дробное число в восьмеричное
                    string octalValue = converter.Convert(binaryInput);
                    // Выводим результат
                    Console.WriteLine($"Восьмеричное представление: {octalValue}");
                }
                catch (FormatException ex)
                {
                    // Обрабатываем ошибку, если введено некорректное двоичное дробное число
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
