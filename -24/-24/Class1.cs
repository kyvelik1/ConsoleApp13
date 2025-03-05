using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Class1
    {
        class DigitDifferenceCalculator
        {
            private int[] originalArray;
            private int[] differenceArray;

            public DigitDifferenceCalculator(int size)
            {
                originalArray = new int[size];
                differenceArray = new int[size];
            }

            public void InputArray()
            {
                Console.WriteLine("Введите 10 двузначных чисел:");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    originalArray[i] = int.Parse(Console.ReadLine());
                }
            }

            public void CalculateDifferences()
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    int number = originalArray[i];
                    int firstDigit = number / 10;
                    int secondDigit = number % 10;
                    differenceArray[i] = Math.Abs(firstDigit - secondDigit);
                }
            }

            public void PrintDifferences()
            {
                Console.WriteLine("Новый массив, состоящий из разностей цифр:");
                for (int i = 0; i < differenceArray.Length; i++)
                {
                    Console.WriteLine(differenceArray[i]);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                DigitDifferenceCalculator calculator = new DigitDifferenceCalculator(10);
                calculator.InputArray();
                calculator.CalculateDifferences();
                calculator.PrintDifferences();
            }
        }
    }
}
