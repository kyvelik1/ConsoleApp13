using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение для A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для B: ");
            int B = int.Parse(Console.ReadLine());

            
            if ((A % 2 == 0 && B % 2 != 0) || (A % 2 != 0 && B % 2 == 0))
            {
                Console.WriteLine("Только одно из чисел A и B четное.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
        static void Main()
        {
            
            Console.Write("Введите значение для A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для C: ");
            int C = int.Parse(Console.ReadLine());

            
            if (A % 3 == 0 && B % 3 == 0 && C % 3 == 0)
            {
                Console.WriteLine("Каждое из чисел A, B и C кратно трем.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
