using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 4 == 0 || N % 7 == 0)
            {
                Console.WriteLine("Число N кратно четырем или семи.");
            }
            else
            {
                Console.WriteLine("Число N не кратно ни четырем, ни семи.");
            }
        }
        static void Main()
        {
            
            Console.Write("Введите значение для N: ");
            int N = int.Parse(Console.ReadLine());

            
            if (N % 5 == 0 && N % 10 != 0)
            {
                Console.WriteLine("Число N кратно пяти и не оканчивается на ноль.");
            }
            else
            {
                Console.WriteLine("Условие не выполнено.");
            }
        }
    }
}
