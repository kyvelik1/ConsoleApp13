using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
       
        
            static void Main()
            {
                int[] originalArray = new int[9];
                int[] sumArray = new int[9];

                // Ввод массива с двузначными числами
                Console.WriteLine("Введите 9 двузначных чисел:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    originalArray[i] = int.Parse(Console.ReadLine());
                    if (originalArray[i] < 10 || originalArray[i] > 99)
                    {
                        Console.WriteLine("Ошибка: введено не двузначное число. Пожалуйста, введите двузначное число.");
                        i--; // Повторяем ввод для текущего элемента
                    }
                }

                // Расчет нового массива с суммами цифр
                for (int i = 0; i < originalArray.Length; i++)
                {
                    int number = originalArray[i];
                    int sum = (number / 10) + (number % 10); // Сумма цифр
                    sumArray[i] = sum;
                }

                // Вывод результатов
                Console.WriteLine("\nИсходный массив:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write($"{originalArray[i]} ");
                }

                Console.WriteLine("\n\nМассив сумм цифр:");
                for (int i = 0; i < sumArray.Length; i++)
                {
                    Console.Write($"{sumArray[i]} ");
                }
            }
        
    }
}
