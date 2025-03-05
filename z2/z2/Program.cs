using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {


        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Запрашиваем у пользователя ввод двоичного числа
                Console.Write("Введите двоичное число: ");
                string binaryInput = Console.ReadLine();

                // Проверяем, является ли введенная строка двоичным числом
                if (!IsBinary(binaryInput))
                {
                    Console.WriteLine("Ошибка: введено некорректное двоичное число.");
                    return;
                }

                // Преобразуем двоичное число в десятичное
                long decimalValue = Convert.ToInt64(binaryInput, 2);

                // Преобразуем десятичное число в восьмеричное
                string octalValue = Convert.ToString(decimalValue, 8);

                // Выводим результат
                Console.WriteLine($"Восьмеричное представление: {octalValue}");
            }

            // Метод для проверки, является ли строка двоичным числом
            private static bool IsBinary(string input)
            {
                foreach (char c in input)
                {
                    if (c != '0' && c != '1')
                        return false;
                }
                return true;
            }
        }
    }
}
