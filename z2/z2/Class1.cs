using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class BinaryToOctalConverter
    {
        // Метод для проверки, является ли строка двоичным числом
        private bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        // Метод для преобразования двоичного числа в восьмеричное
        public string ConvertBinaryToOctal(string binaryInput)
        {
            // Проверяем, является ли введенная строка двоичным числом
            if (!IsBinary(binaryInput))
            {
                throw new FormatException("Ошибка: введено некорректное двоичное число.");
            }

            // Преобразуем двоичное число в десятичное
            long decimalValue = Convert.ToInt64(binaryInput, 2);

            // Преобразуем десятичное число в восьмеричное
            string octalValue = Convert.ToString(decimalValue, 8);

            return octalValue;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            // Создаем экземпляр класса BinaryToOctalConverter
            BinaryToOctalConverter converter = new BinaryToOctalConverter();

            // Запрашиваем у пользователя ввод двоичного числа
            Console.Write("Введите двоичное число: ");
            string binaryInput = Console.ReadLine();

            try
            {
                // Преобразуем двоичное число в восьмеричное
                string octalValue = converter.ConvertBinaryToOctal(binaryInput);
                // Выводим результат
                Console.WriteLine($"Восьмеричное представление: {octalValue}");
            }
            catch (FormatException ex)
            {
                // Обрабатываем ошибку, если введено некорректное двоичное число
                Console.WriteLine(ex.Message);
            }
        }
    }
}
