using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        public class BinaryFractionToDecimalConverter
        {
            // Метод для проверки, является ли строка двоичным дробным числом
            private static bool IsBinaryFraction(string input)
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

            // Метод для преобразования целой части двоичного числа в десятичное
            private static double ConvertBinaryToDecimal(string binary)
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

            // Метод для преобразования дробной части двоичного числа в десятичное
            private static double ConvertBinaryFractionToDecimal(string binaryFraction)
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

            public static void Main(string[] args)
            {
                // Запрашиваем у пользователя ввод двоичного дробного числа
                Console.Write("Введите двоичное дробное число (например, 101.101): ");
                string binaryInput = Console.ReadLine();

                // Проверяем, является ли введенная строка двоичным дробным числом
                if (!IsBinaryFraction(binaryInput))
                {
                    Console.WriteLine("Ошибка: введено некорректное двоичное дробное число.");
                    return;
                }

                // Разделяем число на целую и дробную части
                string[] parts = binaryInput.Split('.');
                string integerPart = parts[0];
                string fractionalPart = parts.Length > 1 ? parts[1] : "0";

                // Преобразуем целую часть в десятичное число
                double decimalValue = ConvertBinaryToDecimal(integerPart);

                // Преобразуем дробную часть в десятичное число и добавляем к результату
                decimalValue += ConvertBinaryFractionToDecimal(fractionalPart);

                // Выводим результат
                Console.WriteLine($"Десятичное представление: {decimalValue}");
            }
        }
    }
}
