using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z12
{
    class Class1
    {
        // Класс для работы с массивами
        public class ArrayProcessor
        {
            // Метод для поиска индексов двух одинаковых элементов
            public (int, int) FindDuplicateIndices(int[] array)
            {
                // Словарь для хранения элементов и их индексов
                Dictionary<int, int> elementIndices = new Dictionary<int, int>();

                for (int i = 0; i < array.Length; i++)
                {
                    if (elementIndices.ContainsKey(array[i]))
                    {
                        // Если элемент уже встречался, возвращаем его индекс и текущий индекс
                        return (elementIndices[array[i]], i);
                    }
                    else
                    {
                        // Иначе сохраняем элемент и его индекс
                        elementIndices[array[i]] = i;
                    }
                }

                // Если дубликаты не найдены, выбрасываем исключение
                throw new InvalidOperationException("Дубликаты не найдены.");
            }
        }

        // Основной класс программы
        public class MainClass
        {
            public static void Main(string[] args)
            {
                // Создаем экземпляр класса ArrayProcessor
                ArrayProcessor arrayProcessor = new ArrayProcessor();

                // Ввод массива
                int[] array = new int[10]; // Пример массива из 10 элементов
                Console.WriteLine("Введите 10 целых чисел:");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                try
                {
                    // Поиск индексов двух одинаковых элементов
                    (int index1, int index2) = arrayProcessor.FindDuplicateIndices(array);

                    // Вывод индексов
                    Console.WriteLine($"Два одинаковых элемента найдены на позициях: {index1 + 1} и {index2 + 1}");
                }
                catch (InvalidOperationException ex)
                {
                    // Обрабатываем ошибку, если дубликаты не найдены
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
