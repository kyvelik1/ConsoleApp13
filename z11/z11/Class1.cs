using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z11
{
    class Class1
    {
        // Класс для работы с массивами
        public class ArrayProcessor
        {
            // Метод для удаления элементов, которые встречаются более двух раз
            public int[] RemoveElementsOccurringMoreThanTwice(int[] array)
            {
                // Словарь для подсчета количества вхождений каждого элемента
                Dictionary<int, int> countDictionary = new Dictionary<int, int>();

                // Подсчет количества вхождений каждого элемента
                foreach (int number in array)
                {
                    if (countDictionary.ContainsKey(number))
                    {
                        countDictionary[number]++;
                    }
                    else
                    {
                        countDictionary[number] = 1;
                    }
                }

                // Формирование нового массива без элементов, которые встречаются более двух раз
                List<int> resultList = new List<int>();
                foreach (int number in array)
                {
                    if (countDictionary[number] <= 2)
                    {
                        resultList.Add(number);
                    }
                }

                return resultList.ToArray();
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayProcessor
                ArrayProcessor arrayProcessor = new ArrayProcessor();

                // Ввод массива из 12 двоичных чисел
                int[] binaryArray = new int[12];
                Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");

                for (int i = 0; i < 12; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    binaryArray[i] = int.Parse(Console.ReadLine());
                }

                // Удаление элементов, которые встречаются более двух раз
                int[] resultArray = arrayProcessor.RemoveElementsOccurringMoreThanTwice(binaryArray);

                // Вывод нового массива
                Console.WriteLine("Новый массив после удаления элементов, которые встречаются более двух раз:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write($"{resultArray[i]} ");
                }
            }
        }
    }
}
