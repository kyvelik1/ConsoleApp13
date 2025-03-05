using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я1
{
    internal class Class1
    {
        class NumberChecker
        {

            private int A;
            private int B;


            public NumberChecker(int a, int b)
            {
                A = a;
                B = b;
            }


            public bool IsOnlyOneEven()
            {
                return (A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0);
            }
        }

        class Program
        {
            static void Main()
            {
                
                Console.Write("Введите значение для A: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write("Введите значение для B: ");
                int B = int.Parse(Console.ReadLine());

                
                NumberChecker checker = new NumberChecker(A, B);

                
                if (checker.IsOnlyOneEven())
                {
                    Console.WriteLine("Только одно из чисел A и B четное.");
                }
                else
                {
                    Console.WriteLine("Условие не выполнено.");
                }
            }
        }
    }
}
       