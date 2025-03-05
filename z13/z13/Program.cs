using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z13
{
    class Program
    {
        // Класс для работы с двоичными числами
        public class BinaryNumberProcessor
        {
            // Метод для циклического сдвига массива влево на две позиции
            public int[] CyclicShiftLeft(int[] binaryArray, int shift)
            {
                int length = binaryArray.Length;
                int[] shiftedArray = new int[length];

                for (int i = 0; i < length; i++)
                {
                    shiftedArray[(i - shift + length) % length] = binaryArray[i];
                }

                return shiftedArray;
            }

            // Метод для преобразования двоичного массива в целое число
            public int BinaryArrayToInt(int[] binaryArray)
            {
                int result = 0;
                for (int i = 0; i < binaryArray.Length; i++)
                {
                    result += binaryArray[i] * (int)Math.Pow(2, binaryArray.Length - 1 - i);
                }
                return result;
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса BinaryNumberProcessor
                BinaryNumberProcessor binaryProcessor = new BinaryNumberProcessor();

                // Ввод двоичного числа в виде массива
                int[] binaryArray = new int[8]; // Пример массива из 8 элементов
                Console.WriteLine("Введите 8 двоичных цифр (0 или 1):");

                for (int i = 0; i < 8; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    binaryArray[i] = int.Parse(Console.ReadLine());
                }

                // Циклический сдвиг массива влево на две позиции
                int[] shiftedArray = binaryProcessor.CyclicShiftLeft(binaryArray, 2);

                // Преобразование исходного и сдвинутого массива в целые числа
                int originalNumber = binaryProcessor.BinaryArrayToInt(binaryArray);
                int shiftedNumber = binaryProcessor.BinaryArrayToInt(shiftedArray);

                // Вычисление разности между исходным и сдвинутым числом
                int difference = originalNumber - shiftedNumber;

                // Вывод результата
                Console.WriteLine($"Исходное число: {originalNumber}");
                Console.WriteLine($"Число после сдвига: {shiftedNumber}");
                Console.WriteLine($"Разность: {difference}");
            }
        }
    }
}
