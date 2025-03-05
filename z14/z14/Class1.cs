using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z14
{
    class Class1
    {
        // Класс для работы с двоичными числами
        public class BinaryNumberProcessor
        {
            // Метод для преобразования двоичного числа в целое
            public int BinaryToInt(string binary)
            {
                return Convert.ToInt32(binary, 2);
            }

            // Метод для преобразования целого числа в двоичное
            public string IntToBinary(int number)
            {
                return Convert.ToString(number, 2);
            }

            // Метод для сортировки массива двоичных чисел по убыванию
            public string[] SortBinaryArrayDescending(string[] binaryArray)
            {
                // Преобразуем двоичные числа в целые
                int[] intArray = binaryArray.Select(b => BinaryToInt(b)).ToArray();

                // Сортируем целые числа по убыванию
                Array.Sort(intArray);
                Array.Reverse(intArray);

                // Преобразуем отсортированные целые числа обратно в двоичные
                return intArray.Select(i => IntToBinary(i)).ToArray();
            }

            // Метод для вычисления суммы двоичных чисел
            public int SumBinaryArray(string[] binaryArray)
            {
                return binaryArray.Sum(b => BinaryToInt(b));
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса BinaryNumberProcessor
                BinaryNumberProcessor binaryProcessor = new BinaryNumberProcessor();

                // Ввод массива двоичных чисел
                string[] binaryArray = new string[5]; // Пример массива из 5 элементов
                Console.WriteLine("Введите 5 двоичных чисел:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    binaryArray[i] = Console.ReadLine();
                }

                // Сортировка массива по убыванию
                string[] sortedArray = binaryProcessor.SortBinaryArrayDescending(binaryArray);

                // Вычисление суммы чисел
                int sum = binaryProcessor.SumBinaryArray(binaryArray);

                // Вывод отсортированного массива
                Console.WriteLine("Отсортированный массив по убыванию:");
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    Console.Write($"{sortedArray[i]} ");
                }

                // Вывод суммы чисел
                Console.WriteLine($"\nСумма чисел: {sum}");
            }
        }
    }
}
