using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main()
        {
            // Ввод исходного массива из 10 двузначных чисел
            int[] originalArray = new int[10];
            Console.WriteLine("Введите 10 двузначных чисел:");
            for (int i = 0; i < 10; i++)
            {
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            // Создание нового массива для хранения разностей цифр
            int[] differenceArray = new int[10];

            // Вычисление разности цифр для каждого элемента исходного массива
            for (int i = 0; i < 10; i++)
            {
                int number = originalArray[i];
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                differenceArray[i] = Math.Abs(firstDigit - secondDigit);
            }

            // Вывод нового массива
            Console.WriteLine("Новый массив, состоящий из разностей цифр:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(differenceArray[i]);
            }
        }
    }
}
